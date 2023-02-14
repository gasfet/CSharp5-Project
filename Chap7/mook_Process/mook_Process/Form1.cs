using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Process 클래스 사용
using System.Collections; //IComparer 사용
using System.Threading; //스레드 사용

namespace mook_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Isort = true; //[lvView] 컨트롤 헤더 정렬
        private Thread ProcessThread; // 프로세스 나타내기 스레드
        private delegate void ProcessUpdateDelegate(); // 델리게이트 생성
        private ProcessUpdateDelegate UpProc = null;

        private PerformanceCounter oCPU = 
            new PerformanceCounter("Processor", "% Processor Time", "_Total"); //시스템 CPU 성능 카운터
        private PerformanceCounter oMem = 
            new PerformanceCounter("Memory", "% Committed Bytes In Use"); //시스템 Mem 성능 카운터
        private PerformanceCounter pCPU = 
            new PerformanceCounter();
        bool bExit = false;
        int iCPU = 0;
        int iMem = 0;
        int cp = 0;
        Thread checkThread = null; //실시간 시스템 정보 체크

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessView(); //프로세스 출력
            ProcessThread = new Thread(ProcessUpdate); //스레드 대리자에 구동 메서드 입력
            ProcessThread.Start(); //스레드 시작
            UpProc = new ProcessUpdateDelegate(ProcessView); //델리게이트에 구동 메서드 입력

            checkThread = new Thread(getCPU_Info);
            checkThread.Start();
        }

        private void ProcessUpdate()
        {
            try
            {
                while (true)
                {
                    var oldlist = new ArrayList();

                    foreach (var oldproc in Process.GetProcesses())
                    {
                        oldlist.Add(oldproc.Id.ToString());
                    }
                    Thread.Sleep(1000);

                    var newproc = Process.GetProcesses();

                    if (oldlist.Count != newproc.Length)
                    {
                        Invoke(UpProc);
                        continue;
                    }

                    int i = 0;

                    foreach (var rewproc in Process.GetProcesses())
                    {
                        if (oldlist[i++].ToString() != rewproc.Id.ToString())
                        {
                            Invoke(UpProc);
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        private void ProcessView()
        {
            try
            {
                this.lvView.Items.Clear();
                cp = 0;
                foreach (var proc in Process.GetProcesses())
                {
                    string[] str;
                    try
                    {
                        str = proc.TotalProcessorTime.ToString().Split(new Char[] { '.' });
                    }
                    catch { str = new string[] { "" }; }

                    var strArray = new string[] { proc.ProcessName.ToString(), proc.Id.ToString(), 
                        str[0], NumFormat(proc.WorkingSet64) };

                    var lvt = new ListViewItem(strArray);
                    this.lvView.Items.Add(lvt);
                    cp++;
                }
            }
            catch { }
            this.tsslProcess.Text = "프로세스 : " + cp.ToString() + "개";
        }

        private string NumFormat(long MemNum)
        {
            MemNum = MemNum / 1024;
            return String.Format("{0:N}", MemNum) + " KB";
        }

        private void getCPU_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                this.tsslCpu.Text = "CPU 사용: " + iCPU.ToString().ToString() + " %";
                iMem = (int)oMem.NextValue();
                this.tsslMem.Text = "실제 메모리 : " + iMem.ToString().ToString() + " %";
                Thread.Sleep(1000);
            }
        }

        private void getProcessMem_info()
        {
            while(!bExit)
            {
                int k = 0;
                Thread.Sleep(2);
                foreach (var proc in Process.GetProcesses())
                {
                    try
                    {
                        if (cp == Process.GetProcesses().Length)
                        {
                            pCPU = new PerformanceCounter("Process", "% Processor Time", proc.ProcessName);
                            pCPU.NextValue();
                            Thread.Sleep(100);
                            this.lvView.Items[k].SubItems[2].Text =
                                String.Format("{0:00}", (int)(pCPU.NextValue() / Environment.ProcessorCount));
                            k++;
                        }
                        else
                            ProcessView();
                    }
                    catch { }
                }
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            ProccessKill(false);
        }

        private void ProccessKill(bool optkill)
        {
            try
            {
                var PID = Convert.ToInt32(this.lvView.SelectedItems[0].SubItems[1].Text);
                Process tProcess = Process.GetProcessById(PID);
                if (!(tProcess == null))
                {
                    var dlr = MessageBox.Show(this.lvView.SelectedItems[0].SubItems[0].Text + 
                        " 프로세스를 끝내시겠습니까?", "알림", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning);
                    if (dlr == DialogResult.Yes)
                    {
                        if (!optkill)
                            tProcess.CloseMainWindow();
                        else
                            tProcess.Kill();
                        ProcessView();
                    }
                }
                else
                {
                    MessageBox.Show(this.lvView.SelectedItems[0].SubItems[0].Text + 
                        "프로세스는 존재하지 않습니다", "알림", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    ProcessView();
                }
            }
            catch
            {
                return;
            }
        }

        private void lvView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (Isort == true)
            {
                this.lvView.ListViewItemSorter = 
                    new ListViewItemComparer(e.Column, Isort); //내림 차순 정렬
                Isort = false;
            }
            else
            {
                this.lvView.ListViewItemSorter = 
                    new ListViewItemComparer(e.Column, Isort); //오름 차순 정렬
                Isort = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(ProcessThread == null))
                ProcessThread.Abort(); //스레드 종료
            if (!(checkThread == null))
                checkThread.Abort(); //스레드 종료
        }
    }

    class ListViewItemComparer : IComparer // [lvView] 컨트롤의 [Items] 속성 값 정렬 외부 클래스
    {
        private int col;
        private bool z;
        public ListViewItemComparer(int column, bool v)
        {
            col = column;
            z = v;
        }
        public int Compare(object x, object y)
        {
            object a, b;
            if (z == true)
            {
                a = x;
                b = y;
            }
            else
            {
                a = y;
                b = x;
            }
            return String.Compare(((ListViewItem)a).SubItems[col].Text, ((ListViewItem)b).SubItems[col].Text);
        }
    }
}
