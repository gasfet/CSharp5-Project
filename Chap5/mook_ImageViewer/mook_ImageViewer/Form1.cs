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

namespace mook_ImageViewer
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }

        private string path = "c:\\"; //기본 경로

        public string ReturnPath
        {
            set
            {
                this.Text = value;
                View(value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView(); //[treeDisk] 컨트롤에 디스크 목록 출력 메서드 호출
        }

        private void TreeView() //[treeDisk] 컨트롤에 디스크 목록 출력
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
            this.treeDisk.ExpandAll();
        }

        public void View(string dr) //[lvFile] 컨트롤에 지정 경로 하위 파일 및 폴더 출력
        {
            this.Text = dr;
            this.lvFile.Items.Clear();
            int imageNum = 15;
            try
            {
                if (Directory.Exists(dr) == false)
                {
                    MessageBox.Show(dr + " 드라이브는 읽을 수 없습니다.", "디스크 삽입", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var di = new DirectoryInfo(dr);

                    foreach (var d in di.GetDirectories())
                    {
                        var lvItem = new ListViewItem(new String[] { d.Name, "", "폴더",
                            d.LastWriteTime.ToShortDateString() }, 16);
                        this.lvFile.Items.Add(lvItem);
                    }

                    foreach (var d in di.GetFiles())
                    {
                        var str = d.Extension;
                        str = str.ToLower();
                        switch (str.ToString())
                        {
                            case ".exe":
                                imageNum = 0;
                                break;
                            case ".com":
                                imageNum = 1;
                                break;
                            case ".txt":
                                imageNum = 2;
                                break;
                            case ".bmp":
                                imageNum = 3;
                                break;
                            case ".doc":
                                imageNum = 4;
                                break;
                            case ".gif":
                                imageNum = 5;
                                break;
                            case ".htm":
                                imageNum = 6;
                                break;
                            case ".html":
                                imageNum = 7;
                                break;
                            case ".hwp":
                                imageNum = 8;
                                break;
                            case ".jpg":
                                imageNum = 9;
                                break;
                            case ".mp3":
                                imageNum = 10;
                                break;
                            case ".mpg":
                                imageNum = 11;
                                break;
                            case ".ra":
                                imageNum = 12;
                                break;
                            case ".rar":
                                imageNum = 13;
                                break;
                            case ".zip":
                                imageNum = 14;
                                break;
                            default:
                                imageNum = 15;
                                break;
                        }
                        var lvi = new ListViewItem(new String[] { d.Name, d.Length.ToString(), 
                            d.Extension, d.LastWriteTime.ToShortDateString() }, imageNum);
                        this.lvFile.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void treeDisk_AfterSelect(object sender, TreeViewEventArgs e) //[lvFile] 컨트롤에 현재 선택되어 있는 트리 노드를 가져오거나 설정
        {
            if (this.treeDisk.SelectedNode.Text != "내 컴퓨터")
            {
                var str = this.treeDisk.SelectedNode.Text.Substring(1, 1);
                View(str + @":\"); //view 메서드 호출
            }
        }

        private void lvFile_Click(object sender, EventArgs e)
        {
            if (this.lvFile.SelectedItems.Count != 0)
            {
                if (this.lvFile.SelectedItems[0].SubItems[2].Text.ToUpper() == ".JPG" || 
                    this.lvFile.SelectedItems[0].SubItems[2].Text.ToUpper() == ".GIF" || 
                    this.lvFile.SelectedItems[0].SubItems[2].Text.ToUpper() == ".BMP")
                {
                    this.tsbtnImg.Enabled = true; // [이미지보기] 이미지 버튼 활성화
                }
                this.tsbtnUp.Enabled = true; //[상위폴더] 이미지 버튼 활성화
            }
        }

        private void lvFile_DoubleClick(object sender, EventArgs e)
        {
            var PathStr = this.lvFile.SelectedItems[0].SubItems[2].Text;
            if (this.lvFile.SelectedItems.Count != 0)
            {
                if (PathStr == "폴더")
                {
                    View(this.Text + this.lvFile.SelectedItems[0].SubItems[0].Text + @"\");
                }
                else if (PathStr.ToUpper() == ".JPG" || PathStr.ToUpper() == ".GIF" || 
                    PathStr.ToUpper() == ".BMP")
                {
                    Form2 frm2 = new Form2();
                    frm2.ResultPath = this.Text + this.lvFile.SelectedItems[0].SubItems[0].Text;
                    this.Hide();
                    frm2.Show();
                }
            }
            else
            {
                MessageBox.Show("디렉토리를 선택해 주세요.", "디렉토리 선택", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                Form2 frm2 = new Form2();
                frm2.ResultPath = this.ofdFile.FileName;
                this.Visible = false; //폼 감추기
                this.ShowInTaskbar = false; //아래 태스크바를 감추기
                frm2.Show(); //Form2 폼 실행
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            View(path); //view 메서드 호출
        }

        private void tsbtnImg_Click(object sender, EventArgs e)
        {
            if (this.lvFile.SelectedItems.Count > 0)
            {
                Form2 frm2 = new Form2();
                frm2.ResultPath = this.Text + this.lvFile.SelectedItems[0].SubItems[0].Text;
                this.Hide(); //폼 감추기
                frm2.Show(); //Form2 폼 보이기
            }
            else
            {
                MessageBox.Show("파일을 선택해 주세요.", "파일 선택", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string str = null;
                string[] astr = this.Text.Split('\\');
                var p = astr.Length;
                if (p > 2)
                {
                    for (int i = 0; i <= p - 3; i++)
                    {
                        str += astr[i] + @"\";
                    }
                    this.Text = str;
                    this.path = str;
                    View(str);
                }
                else
                {
                    MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckView()
        {
            this.작은아이콘ToolStripMenuItem.Checked = false; // 메뉴 체크 표시 해제
            this.큰아이콘ToolStripMenuItem.Checked = false;
            this.리스트ToolStripMenuItem.Checked = false;
            this.간단히ToolStripMenuItem.Checked = false;
        }

        private void 큰아이콘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckView(); //메서드 호출
            this.lvFile.View = System.Windows.Forms.View.LargeIcon; //lvFile 컨틀롤 아이콘 표시 속성
            this.큰아이콘ToolStripMenuItem.Checked = true; //큰아이콘 체크
        }

        private void 작은아이콘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckView(); //메서드 호출
            this.lvFile.View = System.Windows.Forms.View.SmallIcon; //lvFile 컨틀롤 아이콘 표시 속성
            this.작은아이콘ToolStripMenuItem.Checked = true; //작은아이콘 체크
        }

        private void 간단히ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckView(); //메서드 호출
            this.lvFile.View = System.Windows.Forms.View.List; //lvFile 컨틀롤 아이콘 표시 속성
            this.간단히ToolStripMenuItem.Checked = true; //간단히 체크
        }

        private void 리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckView(); //메서드 호출
            this.lvFile.View = System.Windows.Forms.View.Details; //lvFile 컨틀롤 아이콘 표시 속성
            this.리스트ToolStripMenuItem.Checked = true; //리스트 체크
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
