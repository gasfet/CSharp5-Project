using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //파일 클래스 사용
using System.Net.NetworkInformation; //Ping, PingOptions 클래스 사용
using System.Runtime.InteropServices; //DllImport 사용(DLL 파일 사용)
using System.Threading; //스레드 클래스 사용

namespace mook_NetCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread PlayWavSound; //외부 스레드 개체 생성(wav 파일 실행)
        private Thread MessageWavShow; //외부 스레드 개체 생성(메시지 보이기)
        private StreamWriter sw; //파일 스트림 쓰기 개체 생성


        string[] MainstrFileName = DateTime.Now.ToString().Split(new Char[] { ' ' }); //현재 날짜 반환

        Ping pingSender = new Ping(); //ping 클래스 개체 생성
        PingOptions options = new PingOptions(); // PingOptions 클래스 생성


        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //32비트 패킷 생성
        const int timeout = 120; //타임 아웃
        string[] args = new string[1]; //아이피 주소 입력

        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true)] //wav 파일 실행
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags); //winmm.dll 포함 메서드
        [System.Flags]
        public enum PlaySoundFlags : int //플래그 지정 값
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string[] SubstrFileName = DateTime.Now.ToString().Split(new Char[] { ' ' });
            FileInfo f = new FileInfo(@"./Conn/" + SubstrFileName[0] + @"_Connection.txt");
            if (f.Exists == true)
            {
                sw = new StreamWriter(new FileStream(@"./Conn/" + SubstrFileName[0] + @"_Connection.txt", FileMode.Append));
                PingCheck();
            }
            else
            {
                sw = File.CreateText(@"./Conn/" + SubstrFileName[0] + @"_Connection.txt");
                PingCheck();
            }
        }

        private void PingCheck()
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                args[0] = this.txtIP.Text;
                options.DontFragment = true;
                PingReply reply = pingSender.Send(args[0], timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    this.lblConnection.Text = "Net Connect";
                    this.lblRoundtripTimeView.Text = reply.RoundtripTime.ToString();
                    this.lblTtlView.Text = reply.Options.Ttl.ToString();
                    this.lblStateView.Text = reply.Options.DontFragment.ToString();
                    this.lblBufferView.Text = reply.Buffer.Length.ToString();
                    this.lblTimeView.Text = DateTime.Now.ToString();
                    if (this.lbResult.Items.Count == 10)
                    {
                        this.lbResult.Items.Clear();
                        this.lbResult.Items.Add(DateTime.Now.ToString() + " Reply from " + this.txtIP.Text + "; bytes=" + reply.Buffer.Length.ToString() + " time<" + reply.RoundtripTime.ToString() + " TTL=" + reply.Options.Ttl.ToString());
                        sw.WriteLine(DateTime.Now.ToString() + " Reply from " + this.txtIP.Text + "; bytes=" + reply.Buffer.Length.ToString() + " time<" + reply.RoundtripTime.ToString() + " TTL=" + reply.Options.Ttl.ToString());
                        sw.Close();
                    }
                    else
                    {
                        this.lbResult.Items.Add(DateTime.Now.ToString() + " Reply from " + this.txtIP.Text + "; bytes=" + reply.Buffer.Length.ToString() + " time<" + reply.RoundtripTime.ToString() + " TTL=" + reply.Options.Ttl.ToString());
                        sw.WriteLine(DateTime.Now.ToString() + " Reply from " + this.txtIP.Text + "; bytes=" + reply.Buffer.Length.ToString() + " time<" + reply.RoundtripTime.ToString() + " TTL=" + reply.Options.Ttl.ToString());
                        sw.Close();
                    }
                }
                else
                {
                    sw.Close();
                    this.lblConnection.Text = "Net Disconnect";
                    MessageWavShow = new Thread(MessageShow);
                    MessageWavShow.Start();
                    Form2 frm2 = new Form2();
                    frm2.StringIP = this.txtIP.Text;
                    frm2.btnOk.Click += new System.EventHandler(btnOk_Click);
                    frm2.ShowDialog();
                }
            }
            catch
            {
                sw.Close();
                this.Timer.Enabled = false;
                this.btnCheck.Text = "체크";
                MessageBox.Show("네트워크 장애로 인하여 NET Check를 할 수 없습니다.", "에러 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e) //[체크] 버튼 클릭시 [중지] 및 컨트롤의 활성화 또는 비활성화 작업
        {
            if (this.btnCheck.Text == "체크") //Ping 체크 시작
            {
                this.Timer.Enabled = true;
                this.txtIP.Enabled = false;
                this.btnCheck.Text = "중지";
            }
            else //Ping 체크 중지
            {
                this.Timer.Enabled = false;
                this.txtIP.Enabled = true;
                this.btnCheck.Enabled = true;
                this.btnCheck.Text = "체크";
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            this.btnCheck.Enabled = true; //[btnCheck] 컨트롤 활성화 작업
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e) //[Timer] 컨트롤의 [Interval] 속성 값 변경하는 작업
        {
            switch (this.cbTime.Text)
            {
                case "1초":
                    this.Timer.Interval = 1000; //1초 간격 실행
                    break;
                case "2초":
                    this.Timer.Interval = 2000; //2초 간견 실행
                    break;
                case "3초":
                    this.Timer.Interval = 3000;
                    break;
                case "4초":
                    this.Timer.Interval = 4000;
                    break;
                case "5초":
                    this.Timer.Interval = 5000;
                    break;
            }
        }

        private void playWav()
        {
            this.Timer.Enabled = false;
            PlaySound("siren.wav", new System.IntPtr(), PlaySoundFlags.SND_SYNC);
        }
        private void MessageShow()
        {
            this.lblRoundtripTimeView.Text = "실패";
            this.lblTtlView.Text = "실패";
            this.lblStateView.Text = "실패";
            this.lblBufferView.Text = "실패";
            this.lblTimeView.Text = DateTime.Now.ToString();
            this.lbResult.Items.Clear();
            this.lbResult.Items.Add("단말기와 연결이 종료되었습니다.");
            string[] SubstrFileName = DateTime.Now.ToString().Split(new Char[] { ' ' });
            StreamWriter sw = new StreamWriter(new FileStream(@"./Disconn/" + SubstrFileName[0] + @"_Disconnection.txt", FileMode.Append));
            sw.WriteLine(DateTime.Now.ToString() + " 단말기(" + this.txtIP.Text + ") 와 연결이 종료되었습니다.");
            sw.Close();
            PlayWavSound = new Thread(playWav);
            PlayWavSound.Start();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true; //[Timer] 컨트롤를 활성화 하여 Ping 체크 재실시 작업
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"Conn") == false)
                Directory.CreateDirectory("Conn");
            if (Directory.Exists(@"Disconn") == false)
                Directory.CreateDirectory("Disconn");
            this.cbTime.Text = "1초";
            FileInfo f = new FileInfo(@"./Conn/" + MainstrFileName[0] + @"_Connection.txt");
            if (f.Exists != true)
            {
                StreamWriter sw = File.CreateText(@"./Conn/" + MainstrFileName[0] + @"_Connection.txt");
                sw.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(this.PlayWavSound == null))
            {
                PlayWavSound.Abort(); //외부 스레드 종료
            }
            if (!(this.MessageWavShow == null))
            {
                MessageWavShow.Abort(); //외부 스레드 종료
            }
        }
    }
}
