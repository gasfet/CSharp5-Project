using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; //레지스트리 클래스 사용
using System.Runtime.InteropServices; // WinAPI 사용
using System.IO; //파일 관련 클래스 사용
using System.Diagnostics; // Process 클래스 사용


namespace mook_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RegistryKey regKey = Registry.CurrentUser; //레지스트리 클래스 선언
        Form2 frm2 = new Form2(); //폼2 개체 생성
        private string pathstr = String.Format("{0}{1}", 
            Environment.GetFolderPath(Environment.SpecialFolder.Favorites), @"\"); //특수 폴더 경로 설정(즐겨찾기)

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.btnOk.Click += new System.EventHandler(btnOk_Click);
            frm2.ShowDialog();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (frm2.cbAddress.Text.Length > 0)
            {
                this.tscbbAddress.Text = frm2.cbAddress.Text;
                this.webBrowser.Navigate(frm2.cbAddress.Text);
                frm2.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var key = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
            this.tscbbAddress.Text = key.GetValue("Start Page").ToString();
            if (this.tscbbAddress.Text.Length != 0)
            {
                webBrowser.Navigate(this.tscbbAddress.Text);
            }
            LoadURL();
            lvFvList();
        }

        private void LoadURL()
        {
            this.tscbbAddress.Items.Clear(); // Items 속성 초기화
            var R_URL = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\TypedURLs"); //레지스트리 하위치 개체 변수에 대입
            foreach (var reg in R_URL.GetValueNames())
            {
                this.tscbbAddress.Items.Add(R_URL.GetValue(reg.ToString()).ToString());
            }
        }

        private void 닫기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //닫기
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh(); //새로고침
        }

        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop(); //중지
        }

        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome(); //홈으로
            var key = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
            this.tscbbAddress.Text = key.GetValue("Start Page").ToString();
        }

        private void tsbtnRight_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward(); //앞으로 이동
        }

        private void tsbtnLeft_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack(); //뒤로 이동
        }

        private void tscbbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tscbbAddress.Text.Length != 0) //tscbbAddress 컨트롤의 [Text] 속성값이 있다면
            {
                this.webBrowser.Navigate(this.tscbbAddress.Text); //웹사이트 이동
            }
        }

        private void tscbbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.tscbbAddress.Text != "" && e.KeyChar == (Char)13) //tscbbAddress 컨트롤의 [Text] 속성값이 있고 엔터 값이 있을 때
            {
                e.Handled = true;
                this.webBrowser.Navigate(this.tscbbAddress.Text); //웹사이트 이동
            }
        }

        private void 인터넷옵션OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3();
            frm3.ShowDialog(); //폼3 호출
        }

        private void 즐겨찾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (즐겨찾ToolStripMenuItem.Checked == false)
            {
                this.즐겨찾ToolStripMenuItem.Checked = true;
                this.plFvFind.Visible = true;
                lvFvList();
            }
            else
            {
                this.즐겨찾ToolStripMenuItem.Checked = false;
                this.plFvFind.Visible = false;
            }
        }
        private void lvFvList()
        {
            this.lvFvView.Nodes.Clear();
            TreeNode RootNode, SubNode;

            this.lvFvView.BeginUpdate();

            try
            {
                if (Directory.Exists(pathstr) == false) { }
                else
                {
                    var di = new DirectoryInfo(pathstr);

                    var ImgCount = 0;
                    var i = 0;

                    foreach (var d in di.GetDirectories("*"))
                    {
                        this.ImgFvList.Images.Add(ExtractIcon.GetIcon(d.FullName, true, false));
                        RootNode = new TreeNode(d.Name, ImgCount, ImgCount++);
                        this.lvFvView.Nodes.Add(RootNode);

                        if (Directory.Exists(d.FullName) != false)
                        {
                            var subdi = new DirectoryInfo(d.FullName);

                            foreach (var subd in subdi.GetFiles("*.*"))
                            {
                                this.ImgFvList.Images.Add(ExtractIcon.GetIcon(subd.FullName, false, false));
                                SubNode = new TreeNode(subd.Name, ImgCount, ImgCount++);
                                this.lvFvView.Nodes[i].Nodes.Add(SubNode);
                            }
                            i++;
                        }
                    }

                    foreach (var d in di.GetFiles("*.*"))
                    {
                        this.ImgFvList.Images.Add(ExtractIcon.GetIcon(d.FullName, true, false));
                        RootNode = new TreeNode(d.Name, ImgCount, ImgCount++);
                        this.lvFvView.Nodes.Add(RootNode);
                    }
                }
            }
            catch
            {
                MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.lvFvView.EndUpdate();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.즐겨찾ToolStripMenuItem.Checked = false;
            this.plFvFind.Visible = false;
        }

        private void lvFvView_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(pathstr + this.lvFvView.SelectedNode.FullPath.ToString()) == false)
            {
                var myProcess = new Process();
                myProcess.StartInfo.FileName = pathstr + this.lvFvView.SelectedNode.FullPath.ToString();
                myProcess.Start();
            }
        }
    }

    public class ExtractIcon
    {
        [DllImport("Shell32.dll")]
        private static extern int SHGetFileInfo(
            string pszPath, uint dwFileAttributes,
            out SHFILEINFO psfi, uint cbfileInfo,
            SHGFI uFlags);

        private struct SHFILEINFO
        {
            public SHFILEINFO(bool b)
            {
                hIcon = IntPtr.Zero; iIcon = 0; dwAttributes = 0; szDisplayName = ""; szTypeName = "";
            }
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            public string szDisplayName;
            public string szTypeName;
        };

        private enum SHGFI
        {
            SmallIcon = 0x00000001,
            OpenIcon = 0x00000002,
            LargeIcon = 0x00000000,
            Icon = 0x00000100,
            DisplayName = 0x00000200,
            Typename = 0x00000400,
            SysIconIndex = 0x00004000,
            LinkOverlay = 0x00008000,
            UseFileAttributes = 0x00000010
        }

        public static Icon GetIcon(string strPath, bool bSmall, bool bOpen)
        {
            SHFILEINFO info = new SHFILEINFO(true);
            int cbFileInfo = Marshal.SizeOf(info);
            SHGFI flags;

            if (bSmall)
                flags = SHGFI.Icon | SHGFI.SmallIcon;
            else
                flags = SHGFI.Icon | SHGFI.LargeIcon;

            if (bOpen) flags = flags | SHGFI.OpenIcon;

            SHGetFileInfo(strPath, 0, out info, (uint)cbFileInfo, flags);

            return Icon.FromHandle(info.hIcon);
        }
    }
}
