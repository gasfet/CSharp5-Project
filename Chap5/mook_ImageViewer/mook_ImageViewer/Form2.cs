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
using System.Collections; //ArrayList 클래스 사용

namespace mook_ImageViewer
{
    public partial class Form2 : Form
    {
        public string ResultPath = ""; //파일 경로 
        private PictureBox picTmp = new PictureBox(); //PictureBox 컨트롤 개체 생성, 파일 회전시 사용
        ArrayList arrlist = new ArrayList(); //이전 또는 다음 이미지 넘길때 이미지 이름 저장 및 반환
        private string Imagepath = ""; // 이미지 경로
        private int nexti = 0; //이미지 넘길 때 변수

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.pbImg.Image = new Bitmap(Image.FromFile(this.ResultPath));
            ImageArray(this.ResultPath);
            FormReSize();
        }

        private void ImageArray(string PathString)
        {
            var strPath = Directory.GetParent(PathString).ToString() + @"\";
            Imagepath = strPath;

            var file = new DirectoryInfo(strPath);

            foreach (var f in file.GetFiles("*.*"))
            {
                var ExtensionStr = f.Extension.ToLower();
                if (ExtensionStr == ".jpg" || ExtensionStr == ".bmp" || ExtensionStr == ".gif")
                {
                    arrlist.Add(f.Name);
                }
            }
        }

        private void FormReSize()
        {
            var nHeight = this.tsBar.Height + this.pbImg.Height + 40;
            var nWidth = this.pbImg.Width + 40;

            if (this.Height < nHeight)
                this.Height = nHeight;
            else
                this.Height = nHeight;

            if (this.Width < nWidth)
                this.Width = nWidth;
            else
                this.Width = nWidth;

            this.pbImg.Top = (int)((this.Height / 2) - (pbImg.Height / 2));
            this.pbImg.Left = (int)((this.Width / 2) - (pbImg.Width / 2));
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this != null)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void 도회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picTmp.Image = this.pbImg.Image;
            picTmp.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.pbImg.Image = picTmp.Image;
            FormReSize();
        }

        private void 도회전ToolStripMenuItem1_Click(object sender, EventArgs e) //180도 회전
        {
            picTmp.Image = this.pbImg.Image;
            picTmp.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.pbImg.Image = picTmp.Image;
            FormReSize();
        }

        private void 도회전ToolStripMenuItem2_Click(object sender, EventArgs e) //270도 회전
        {
            picTmp.Image = this.pbImg.Image;
            picTmp.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            this.pbImg.Image = picTmp.Image;
            FormReSize();
        }

        private void tsbtnOld_Click(object sender, EventArgs e)
        {
            this.pbImg.Image = new Bitmap(Image.FromFile(this.ResultPath)); //[pbImg] 컨트롤에 이미지 파일 재로드
            FormReSize(); //폼 사이즈 조정 메서드 호출
        }

        private void tsbtnFileList_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); // 폼1 호출
            FileInfo fi = new FileInfo(this.ResultPath); //현재 이미지 파일 경로 대입
            frm1.ReturnPath = fi.DirectoryName + @"\";
            this.Dispose(); //폼2 종료
            frm1.Show();
        }

        private void tsbtnFull_Click(object sender, EventArgs e)
        {
            FullDisplay(); //풀스크린 모드 전환 메서드 호출
        }

        private void FullDisplay()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.tsBar.Visible = false;
            Cursor.Show();
            this.WindowState = FormWindowState.Maximized;
            Rectangle fullScreen = Screen.PrimaryScreen.Bounds;
            this.pbImg.Location = new Point(Convert.ToInt32((fullScreen.Width / 2) - (pbImg.Width / 2)), Convert.ToInt32((fullScreen.Height / 2) - (pbImg.Height / 2)));
            this.pbImg.ContextMenuStrip = ctmenu;
            this.ContextMenuStrip = ctmenu;
        }

        private void 전체화면끝내기EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.tsBar.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.pbImg.ContextMenuStrip = null;
            this.ContextMenuStrip = null;
            FormReSize();
        }

        private void 목록보기LToolStripMenuItem_Click(object sender, EventArgs e) //폼1 호출 현 이미지 경로 설정
        {
            Form1 frm1 = new Form1();
            FileInfo fi = new FileInfo(this.ResultPath);
            frm1.ReturnPath = fi.DirectoryName + @"\";
            this.Dispose();
            frm1.Show();
        }

        private void tsbtnPre_Click(object sender, EventArgs e)
        {
            var i = arrlist.Count; //이미지 파일 개수

            if (nexti > 0)
            {
                nexti--;
                pbImg.Image = Image.FromFile(Imagepath + arrlist[nexti].ToString()); //[pbImg] 컨트롤에 이미지 재설정
                this.Text = arrlist[nexti].ToString();
                this.ResultPath = Imagepath + arrlist[nexti].ToString();
            }
            else
            {
                nexti = i;
            }
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            var i = arrlist.Count - 1; //이미지 파일 개수
            if (nexti < i)
            {
                nexti++; //다음 이미지 파일 설정 인덱스 값
                pbImg.Image = Image.FromFile(Imagepath + arrlist[nexti].ToString()); //인덱스에 매칭되는 arrlist 개체의 이미지 파일명 설정
                this.Text = arrlist[nexti].ToString();
                this.ResultPath = Imagepath + arrlist[nexti].ToString(); //경로에 현재 이미지 경로 설정
            }
            else
            {
                nexti = -1; //초기 이미지 인덱스 값 설정
            }
        }

        private void tsbtnSlide_Click(object sender, EventArgs e)
        {
            FullDisplay(); //풀 스크린 모드 메서드 호출
            this.Timer.Enabled = true; //슬라이드 이미지 자동 넘기기 실행
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var i = arrlist.Count - 1;
            if (nexti < i)
            {
                nexti++;
                pbImg.Image = Image.FromFile(Imagepath + arrlist[nexti].ToString());
                Rectangle fullScreen = Screen.PrimaryScreen.Bounds;
                this.pbImg.Location = new Point(Convert.ToInt32((fullScreen.Width / 2) - (pbImg.Width / 2)), Convert.ToInt32((fullScreen.Height / 2) - (pbImg.Height / 2)));
                this.Text = arrlist[nexti].ToString();
                this.ResultPath = Imagepath + arrlist[nexti].ToString();
            }
            else
            {
                nexti = -1;
            }
        }
    }
}