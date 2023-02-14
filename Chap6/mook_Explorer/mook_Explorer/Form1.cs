using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //파일 클래스 이용
using System.Management; //ManagementObjectSearcher 클래스 이용(시스템 디스크 드라이브 검색)
using System.Diagnostics; //Process 클래스 이용(파일 실행)
using System.Threading; //스레드 클래스 이용
using System.Runtime.InteropServices; //DllImportAttribute 클래스 이용

namespace mook_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = "c:\\"; //기본 경로
        private Thread DiskView; //디스크 드라이브 검색 스레드
        private ManagementObjectSearcher Mquery = new 
            ManagementObjectSearcher("SELECT * From Win32_LogicalDisk"); //로컬 디스크 검색 WMI 쿼리문
        private Boolean Start = false; //while 루프 실행
        private delegate void AddDiskDelegate(); // 델리게이트 생성
        private AddDiskDelegate AddDisk = null; // 대리자 개체를 초기화한다.
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView();
            DiskView = new Thread(DiskUpdate);
            DiskView.Start();
            AddDisk = new AddDiskDelegate(TreeView);
            this.treeDisk.ExpandAll();
        }

        private void DiskUpdate()
        {
            var bqueryCollection = Mquery.Get();
            while (Start)
            {
                var query = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
                var aqueryCollection = query.Get();
                if (aqueryCollection.Count != bqueryCollection.Count)
                {
                    Start = false;
                    Mquery = query;
                    bqueryCollection = aqueryCollection;
                    Invoke(AddDisk);
                }
                this.treeDisk.ExpandAll();
            }
        }

        private void TreeView()
        {
            this.treeDisk.Nodes.Clear();
            TreeNode RootNode, SubNode;
            var imageIndex = 5;
            var selectIndex = 5;

            //const int Unknown = 0;
            //const int NoRootDirectory = 1;
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            //const int NetworkDrive = 4;
            const int CompactDisc = 5;
            const int RAMDisk = 6;


            var query = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
            var queryCollection = query.Get();

            this.treeDisk.BeginUpdate();
            RootNode = new TreeNode("내 컴퓨터", imageIndex, selectIndex);
            this.treeDisk.Nodes.Add(RootNode);

            foreach (var drive in queryCollection)
            {
                switch (int.Parse(drive["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        imageIndex = 0;
                        selectIndex = 0;
                        break;
                    case LocalDisk:
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case CompactDisc:
                        imageIndex = 2;
                        selectIndex = 2;
                        break;
                    case RAMDisk:
                        imageIndex = 3;
                        selectIndex = 3;
                        break;
                    default:
                        imageIndex = 0;
                        selectIndex = 0;
                        break;
                }

                SubNode = new TreeNode("(" + drive["Name"].ToString() + ")", imageIndex, selectIndex);
                this.treeDisk.Nodes[0].Nodes.Add(SubNode);
            }
            this.treeDisk.EndUpdate();
            Start = true;
        }

        private void View(string dr)
        {
            this.Text = path;
            this.lvFile.Items.Clear();
            this.ImgListLarge.Images.Clear();
            this.ImgListSmall.Images.Clear();

            try
            {
                if (Directory.Exists(dr) == false)
                {
                    MessageBox.Show(dr + " 드라이브는 읽을 수 없습니다.", "디스크 삽입", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var di = new DirectoryInfo(dr);

                    var ImgCount = 0;

                    foreach (var d in di.GetDirectories("*"))
                    {
                        this.ImgListSmall.Images.Add(ExtractIcon.GetIcon(d.FullName, true, false));
                        this.ImgListLarge.Images.Add(ExtractIcon.GetIcon(d.FullName, false, false));
                        this.ImgListBig.Images.Add(ExtractIcon.GetIcon(d.FullName, false, false));
                        var lvItem = new ListViewItem(new String[] { d.Name, "", "폴더", d.LastWriteTime.ToShortDateString() }, ImgCount++);
                        this.lvFile.Items.Add(lvItem);
                    }

                    var ExtensionStr = "";

                    foreach (var d in di.GetFiles("*.*"))
                    {
                        try { ExtensionStr = d.Extension.Split(new char[] { '.' })[1]; }
                        catch { ExtensionStr = ""; }
                        this.ImgListSmall.Images.Add(ExtractIcon.GetIcon(d.FullName, true, false));
                        this.ImgListLarge.Images.Add(ExtractIcon.GetIcon(d.FullName, false, false));
                        this.ImgListBig.Images.Add(ExtractIcon.GetIcon(d.FullName, false, false));
                        var lvi = new ListViewItem(new String[] { d.Name, d.Length.ToString(), ExtensionStr, d.LastWriteTime.ToShortDateString() }, ImgCount++);
                        this.lvFile.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeDisk_AfterSelect(object sender, TreeViewEventArgs e) //[treeDisk] 컨트롤의 노드를 선택하였을 때 발생
        {
            if (this.treeDisk.SelectedNode.Text != "내 컴퓨터")
            {
                var str = this.treeDisk.SelectedNode.Text.Substring(1, 1);
                path = str + @":\"; //tree view 컨트롤에 현재 선택되어 있는 트리 노드를 가져오거나 설정합니다.
                View(path); //view 메서드 호출
            }
        }

        private void lvFile_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvFile.SelectedItems.Count != 0)
            {
                if (Directory.Exists(path + this.lvFile.SelectedItems[0].SubItems[0].Text + @"\") == true)
                {
                    path = path + this.lvFile.SelectedItems[0].SubItems[0].Text + @"\";
                    View(path);
                }
                else
                {
                    var myProcess = new Process();
                    myProcess.StartInfo.FileName = path + this.lvFile.SelectedItems[0].SubItems[0].Text;
                    myProcess.Start();
                }
            }
            else
            {
                MessageBox.Show("디렉토리를 선택해 주세요.", "디렉토리 선택", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //폼 종료시 발생
        {
            if (!(DiskView == null))
            {
                DiskView.Abort(); // DiskView 스레드가 존재하면 스레드 종료
            }
        }

        private void 큰아이콘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.큰아이콘ToolStripMenuItem.Checked = true; //큰아이콘 메뉴 선택
            this.아이콘ToolStripMenuItem.Checked = false; //아이콘 메뉴 선택 해제
            this.자세히ToolStripMenuItem.Checked = false; //자세히 메뉴 선택 해제
            this.lvFile.LargeImageList = this.ImgListBig; //[lvFile] 컨트롤 [LargeImageList] 속성에 ImgListBig 대입
            this.lvFile.View = System.Windows.Forms.View.LargeIcon; //[View] 속성 LargeIcon으로 변경
        }

        private void 아이콘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.큰아이콘ToolStripMenuItem.Checked = false; //큰아이콘 메뉴 선택 해제
            this.아이콘ToolStripMenuItem.Checked = true;  //아이콘 메뉴 선택
            this.자세히ToolStripMenuItem.Checked = false; //자세히 메뉴 선택 해제
            this.lvFile.LargeImageList = this.ImgListLarge; //[lvFile] 컨트롤 [LargeImageList] 속성에 ImgListLarge 대입
            this.lvFile.View = System.Windows.Forms.View.LargeIcon; //[View] 속성 LargeIcon으로 변경
        }

        private void 자세히ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.큰아이콘ToolStripMenuItem.Checked = false; //큰아이콘 메뉴 선택 해제
            this.아이콘ToolStripMenuItem.Checked = false; //자세히 메뉴 선택 해제
            this.자세히ToolStripMenuItem.Checked = true; //자세히 메뉴 선택
            this.lvFile.SmallImageList = this.ImgListSmall; //[lvFile] 컨트롤 [LargeImageList] 속성에 ImgListSmall 대입
            this.lvFile.View = System.Windows.Forms.View.Details; //[View] 속성 Details으로 변경
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                string str = null;
                string[] astr = this.path.Split('\\'); //'\' 단위로 분리하여 배열에 저장
                p = astr.Length;
                if (p > 2)
                {
                    for (int i = 0; i <= p - 3; i++) //배열의 길이-1 만큼 for 문 루프 실행
                    {
                        str += astr[i] + @"\"; // 상위 경로 변수에 저장
                    }
                    this.path = str;
                    View(str); //View() 메서드 호출하여 상위 폴더 하위 파일 출력
                }
                else
                {
                    MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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