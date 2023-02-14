using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Painting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int myShape; //선 모양
        Point myPointStart; //마우스 시작 좌표
        Point myPointEnd; //마우스 끝 좌표
        Pen myPen; //선,곡선을 그리는 객체
        Pen myPenTemp; //선,곡선을 그리는 객체
        int sizeX; //원, 사각형의 가로 크기
        int sizeY; //원, 사각형의 세로 크기
        Boolean myPress; //마우스가 눌러짐
        Graphics g; //Graphics 객체
        Rectangle rect; //원, 사각형을 보여주기 위한 Rectangle

        private void Form1_Load(object sender, EventArgs e)
        {
            this.myShape = 0;
            this.myPointStart = new Point(0, 0);
            this.myPointEnd = new Point(0, 0);
            this.myPen = new Pen(Color.Black, 1);
            this.myPenTemp = new Pen(Color.Black, 1);
            this.sizeX = 0;
            this.sizeY = 0;
            this.myPress = false;
            this.g = Graphics.FromHwnd(this.Handle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.myPress = true; //마우스가 눌러짐
            this.myPointStart.X = e.X; //마우스가 눌러진 X 좌표
            this.myPointStart.Y = e.Y; //마우스가 눌러진 Y 좌표
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (myShape == 0)
            {
                if (this.myPress)
                {
                    g.Clear(Color.White);
                    this.myPointEnd = new Point(e.X, e.Y);
                    g.DrawLine(this.myPen, this.myPointStart, this.myPointEnd);
                }
            }
            else if (myShape == 1)
            {
                this.myPointEnd = new Point(e.X, e.Y);
                if (this.myPointEnd != this.myPointStart && this.myPress)
                {
                    g.DrawLine(this.myPen, this.myPointStart.X, this.myPointStart.Y, e.X, e.Y);
                }
                this.myPointStart = this.myPointEnd;
            }
            else if (myShape == 2)
            {
                if (this.myPress)
                {
                    g.Clear(Color.White);
                    this.sizeX = Math.Abs(e.X - this.myPointStart.X);
                    this.sizeY = Math.Abs(e.Y - this.myPointStart.Y);
                    if (this.sizeX == 0)
                    {
                        this.sizeX = 1;
                    }
                    if (this.sizeY == 0)
                    {
                        this.sizeY = 1;
                    }
                    this.rect = new Rectangle(this.myPointStart.X, this.myPointStart.Y, this.sizeX, this.sizeY);
                    g.DrawArc(this.myPen, this.rect, 0, 365);
                }
            }
            else if (myShape == 3)
            {
                if (this.myPress)
                {
                    g.Clear(Color.White);
                    this.sizeX = Math.Abs(e.X - this.myPointStart.X);
                    this.sizeY = Math.Abs(e.Y - this.myPointStart.Y);
                    if (this.sizeX == 0)
                    {
                        this.sizeX = 1;
                    }
                    if (this.sizeY == 0)
                    {
                        this.sizeY = 1;
                    }
                    this.rect = new Rectangle(this.myPointStart.X, this.myPointStart.Y, this.sizeX, this.sizeY);
                    g.DrawRectangle(this.myPen, this.rect);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.myShape == 0)
            {
                this.myPointEnd = new Point(e.X, e.Y);
                g.DrawLine(this.myPen, this.myPointStart, this.myPointEnd);
            }
            else if (this.myShape == 2)
            {
                this.sizeX = Math.Abs(e.X - this.myPointStart.X);
                this.sizeY = Math.Abs(e.Y - this.myPointStart.Y);
                if (this.sizeX == 0)
                {
                    this.sizeX = 1;
                }
                if (this.sizeY == 0)
                {
                    this.sizeY = 1;
                }
                this.rect = new Rectangle(this.myPointStart.X, this.myPointStart.Y, this.sizeX, this.sizeY);
                g.DrawArc(this.myPen, this.rect, 0, 365);
            }
            else if (this.myShape == 3)
            {
                this.sizeX = Math.Abs(e.X - this.myPointStart.X);
                this.sizeY = Math.Abs(e.Y - this.myPointStart.Y);
                if (this.sizeX == 0)
                {
                    this.sizeX = 1;
                }
                if (this.sizeY == 0)
                {
                    this.sizeY = 1;
                }
                this.rect = new Rectangle(this.myPointStart.X, this.myPointStart.Y, this.sizeX, this.sizeY);
                g.DrawRectangle(this.myPen, this.rect);
            }
            this.myPress = false;
        }

        private void 새로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White); //그림 판 초기화
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 끝내기
        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myShape = 0; //직선 그리기
            LineCheckedClear();
            this.직선ToolStripMenuItem.Checked = true;
        }

        private void 곡선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myShape = 1; //곡선 그리기
            LineCheckedClear();
            this.곡선ToolStripMenuItem.Checked = true;
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myShape = 2; //원 그리기
            LineCheckedClear();
            this.원ToolStripMenuItem.Checked = true;
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myShape = 3; //사각형 그리기
            LineCheckedClear();
            this.사각형ToolStripMenuItem.Checked = true;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            myPen.Width = 1.0F; //굵기 1
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            myPen.Width = 2.0F; //굵기 2
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            myPen.Width = 3.0F; //굵기 3
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            myPen.Width = 4.0F; //굵기 4
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            myPen.Width = 5.0F; //굵기 5
        }

        private void 색편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.cdColor.ShowDialog()) //색 대화상자 호출
            {
                this.myPen.Color = this.cdColor.Color;  //myPen에 선택된 색상 적용
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White); //그림 판 초기화
        }

        private void tsbtnBlack_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Black; //선 색상 검정색
        }

        private void tsbtnRed_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Red; //선 색상 빨간색
        }

        private void tsbtnBlue_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Blue; //선 색상 파란색
        }

        private void tsbtnYellow_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Yellow; //선 색상 노란색
        }

        private void tsbtnLine01_Click(object sender, EventArgs e)
        {
            myShape = 0; //직선 그리기
            LineCheckedClear();
            this.직선ToolStripMenuItem.Checked = true;
        }

        private void tsbtnLine02_Click(object sender, EventArgs e)
        {
            myShape = 1; //곡선 그리기
            LineCheckedClear();
            this.곡선ToolStripMenuItem.Checked = true;
        }

        private void tsbtnLine03_Click(object sender, EventArgs e)
        {
            myShape = 2; //원 그리기
            LineCheckedClear();
            this.원ToolStripMenuItem.Checked = true;
        }

        private void tsbtnLine04_Click(object sender, EventArgs e)
        {
            myShape = 3; //사각형 그리기
            LineCheckedClear();
            this.사각형ToolStripMenuItem.Checked = true;
        }

        private void LineCheckedClear()
        {
            this.직선ToolStripMenuItem.Checked = false;
            this.곡선ToolStripMenuItem.Checked = false;
            this.원ToolStripMenuItem.Checked = false;
            this.사각형ToolStripMenuItem.Checked = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.g = Graphics.FromHwnd(this.Handle);
        }
    }
}
