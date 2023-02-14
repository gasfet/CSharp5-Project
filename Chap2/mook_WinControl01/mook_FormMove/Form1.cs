using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_FormMove
{
    public partial class Form1 : Form
    {
        Point ptMouseCurrentPos; // 마우스 클릭 좌표 지정
        Point ptMouseNewPos; // 이동시 마우스 좌표
        Point ptFormCurrentPos; // 폼 위치 좌표 지정
        Point ptFormNewPos; // 이동시 폼 위치 좌표
        bool bFormMouseDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void picMinimize_Click(object sender, EventArgs e) // 폼 최소화
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_MouseDown(object sender, MouseEventArgs e) // 버튼 눌린 이미지 설정
        {
            this.picMinimize.Image = Image.FromFile(@"..\..\img\Minimize_Down.jpg");
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e) // 초기 버튼 이미지 설정
        {
            this.picMinimize.Image = Image.FromFile(@"..\..\img\Minimize_Normal.jpg");
        }

        private void picMinimize_MouseMove(object sender, MouseEventArgs e) // 버튼 위에 마우스 위치시 이미지 설정
        {
            this.picMinimize.Image = Image.FromFile(@"..\..\img\Minimize_Over.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picMinimize.Image = Image.FromFile(@"..\..\img\Minimize_Normal.jpg");

            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Normal.jpg");;
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Down.jpg");
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Normal.jpg");
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Over.jpg");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bFormMouseDown = true; // 왼쪽 마우스 클릭 체크
                ptMouseCurrentPos = Control.MousePosition; // 마우스 클릭 좌표
                ptFormCurrentPos = this.Location; // 폼의 위치 좌표
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                bFormMouseDown = false; // 왼쪽 마우스 클릭 해체 체크
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bFormMouseDown == true) // 왼쪽 마우스 클릭시
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X; //마우스 이동시 가로 좌표
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y; //마우스 이동시 세로 좌표
                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }
    }
}
