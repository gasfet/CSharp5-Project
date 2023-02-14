using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace mook_TextEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "c:\\"; //기본 경로
        Form2 ChildF;
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView(); //treeView() 메소드 호출
        }

        private void TreeView()
        {
            TreeNode RootNode, SubNode;
            int imageIndex = 5;
            int selectIndex = 5;

            //const int Unknown = 0;
            //const int NoRootDirectory = 1;
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            //const int NetworkDrive = 4;
            const int CompactDisc = 5;
            const int RAMDisk = 6;


            var query = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            this.tvDive.BeginUpdate();
            RootNode = new TreeNode("내 컴퓨터", imageIndex, selectIndex);
            this.tvDive.Nodes.Add(RootNode);

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
                this.tvDive.Nodes[0].Nodes.Add(SubNode);
            }
            this.tvDive.EndUpdate();
        }

        private void View(string dr)
        {
            this.Text = path;
            this.lvFolder.Items.Clear();
            this.lvFile.Items.Clear();
            int imageNum = 15;
            try
            {
                if (Directory.Exists(dr) == false)
                {
                    MessageBox.Show(dr + " 드라이브는 읽을 수 없습니다.", "디스크 삽입", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var lvItema = new ListViewItem(new String[] { "..", "폴더" }, 16);
                    this.lvFolder.Items.Add(lvItema);

                    var di = new DirectoryInfo(dr);

                    foreach (DirectoryInfo d in di.GetDirectories())
                    {
                        var lvItemb = new ListViewItem(new String[] { d.Name, "폴더" }, 16);
                        this.lvFolder.Items.Add(lvItemb);
                    }


                    foreach (var d in di.GetFiles())
                    {
                        string str = d.Extension;
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
                        var lvi = new ListViewItem(new String[] { d.Name, "파일" }, imageNum);
                        this.lvFile.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvDive_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvDive.SelectedNode.Text != "내 컴퓨터")
            {
                string str = this.tvDive.SelectedNode.Text.Substring(1, 1);
                path = str + @":\"; //tree view 컨트롤에 현재 선택되어 있는 트리 노드를 가져오거나 설정합니다.
                View(path); //view 메서드 호출
            }
        }

        private void lvFolder_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvFolder.SelectedItems.Count != 0)
            {
                if (this.lvFolder.SelectedItems[0].SubItems[1].Text == "폴더" && this.lvFolder.SelectedItems[0].SubItems[0].Text != "..")
                {
                    path = path + this.lvFolder.SelectedItems[0].SubItems[0].Text + @"\";
                    View(path);
                }
                else
                {
                    try
                    {
                        var str = "";
                        var astr = this.path.Split('\\');
                        var p = astr.Length;
                        if (p > 2)
                        {
                            for (var i = 0; i <= p - 3; i++)
                            {
                                str += astr[i] + @"\";
                            }
                            this.path = str;
                            View(str);
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
            else
            {
                MessageBox.Show("디렉토리를 선택해 주세요.", "디렉토리 선택", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowForm2(string FilePath)
        {
            var extendOp = FilePath.Substring(FilePath.ToString().LastIndexOf(".") + 1);
            var fileName = FilePath.ToString().Substring(FilePath.ToString().LastIndexOf(@"\") + 1);
            ChildF.rtbText.Text = FilePath;
            ChildF.rtbText.LoadFile(ChildF.rtbText.Text, GetRichType(extendOp));
            ChildF.rtbText.Tag = FilePath;
        }

        private RichTextBoxStreamType GetRichType(string inValue)
        {
            var rt = RichTextBoxStreamType.PlainText;
            switch (inValue)
            {
                case "txt":
                    break;
                case "rtf":
                    rt = RichTextBoxStreamType.RichText;
                    break;
                case "vb":
                    rt = RichTextBoxStreamType.PlainText;
                    break;
                case "html":
                    rt = RichTextBoxStreamType.PlainText;
                    break;
            }
            return rt;
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm();
        }
        private void NewForm()
        {
            try
            {
                if (this.ChildF.IsDisposed)
                {
                    ChildF = new Form2(); //폼2 객체 선언
                    ChildF.MdiParent = this;
                    ChildF.Show();
                }
            }
            catch
            {
                ChildF = new Form2(); //폼2 객체 선언
                ChildF.MdiParent = this;
                ChildF.Show();
            }
        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(); //파일 저장 사용자 메서드 호출
        }
        private void Save()
        {
            if (!(ChildF == null || !ChildF.Visible))
            {
                var dlr = this.sfdFile.ShowDialog(); //[저장] 대화상자 호출
                if (dlr != DialogResult.Cancel)
                {
                    var str = this.sfdFile.FileName;
                    var sw = new StreamWriter(str, false, System.Text.Encoding.Default); //쓰기스트림 개체를 생성
                    sw.Write(ChildF.rtbText.Text); //Write() 메서드를 이용하여 파일생성
                    sw.Flush();
                    sw.Close(); //스트림 개체 리소스 해제
                }
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(); //파일 저장 사용자 메서드 호출
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 종료
        }

        private void 되돌리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl1("undo");
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl1("copy");
        }

        private void 자르기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl1("cut");
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl1("all");
        }

        private void TextControl1(string Action)
        {
            if (!(ChildF == null || !ChildF.Visible))
            {
                try
                {
                    switch (Action)
                    {
                        case "undo":
                            ChildF.rtbText.Undo(); //실행 취소
                            break;
                        case "copy":
                            ChildF.rtbText.Copy(); //복사하기
                            break;
                        case "cut":
                            ChildF.rtbText.Cut(); //잘라내기
                            break;
                        case "all":
                            ChildF.rtbText.SelectAll(); //모두 선택
                            break;
                        case "redo":
                            ChildF.rtbText.Redo(); //실행 취소
                            break;
                    }
                }
                catch { }
            }
        }
        private void TextControl2(string Action)
        {
            if (!(ChildF == null || !ChildF.Visible))
            {
                try
                {
                    switch (Action)
                    {
                        case "left":
                            ChildF.rtbText.SelectionAlignment = HorizontalAlignment.Left; //좌측 정렬
                            break;
                        case "center":
                            ChildF.rtbText.SelectionAlignment = HorizontalAlignment.Center; //좌측 정렬
                            break;
                        case "right":
                            ChildF.rtbText.SelectionAlignment = HorizontalAlignment.Right; //좌측 정렬
                            break;
                    }
                }
                catch { }
            }
        }

        private void 왼쪽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl2("left");
        }

        private void 가운데ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl2("center");
        }

        private void 오른쪽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextControl2("right");
        }

        private void 편집상자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (편집상자ToolStripMenuItem.Checked)
            {
                this.tsBar.Visible = false;
                this.편집상자ToolStripMenuItem.Checked = false;
            }
            else
            {
                this.tsBar.Visible = true;
                this.편집상자ToolStripMenuItem.Checked = true;
            }
        }

        private void 파일보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (파일보기ToolStripMenuItem.Checked)
            {
                this.plGroup.Visible = false;
                this.파일보기ToolStripMenuItem.Checked = false;
            }
            else
            {
                this.plGroup.Visible = true;
                this.파일보기ToolStripMenuItem.Checked = true;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            NewForm(); //새로 만들기
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save(); //저장
        }

        private void tsbPrvious_Click(object sender, EventArgs e)
        {
            TextControl1("undo");
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            TextControl1("redo");
        }

        private void tsbNormal_Click(object sender, EventArgs e)
        {
            TextControl2("left");
        }

        private void tsbCenter_Click(object sender, EventArgs e)
        {
            TextControl2("center");
        }

        private void tsbRight_Click(object sender, EventArgs e)
        {
            TextControl2("right");
        }

        private void lvFile_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    lvFile.DoDragDrop(path + lvFile.SelectedItems[0].Text, DragDropEffects.All);
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //어플리케이션 종료
        }

        private void lvFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !(ChildF == null || !ChildF.Visible))
            {
                string FilePath = path + this.lvFile.SelectedItems[0].SubItems[0].Text;
                ShowForm2(FilePath);
            }
        }

    }
}