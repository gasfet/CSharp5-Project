using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Screen
{
    public partial class Form1 : Form
    {
        Rectangle fullScreen = Screen.PrimaryScreen.Bounds; //화면 사이즈
        private int marqueeLocation = 0; //이동 
        private int mXStart = 0; //마우스 포인트 가로 좌표
        private int mYStart = 0; //마우스 포인트 세로 좌표
        private bool LKTime = true;
        static public bool LkSreen = true; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lblTitle.Location = new 
                Point(Convert.ToInt32(fullScreen.Width) - marqueeLocation, 10);
            this.lblTitle.Visible = true;
            marqueeLocation += 2;
            if (this.lblTitle.Location.X <= -this.lblTitle.Width)
            {
                marqueeLocation = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LockTimer.Enabled = true;
            LKTime = true;
            Cursor.Hide();
            ShowScreenSaver();
        }
        private void ShowScreenSaver()
        {
            this.pbImg.Location = new Point(Convert.ToInt32(fullScreen.Width / 2 - 200), 
                Convert.ToInt32(fullScreen.Height / 2 - 250));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((mXStart == 0) && (mYStart == 0)) //초기 포인터 설정
            {
                mXStart = e.X;
                mYStart = e.Y;
                return;
            }
            else if ((e.X != mXStart) || (e.Y != mYStart)) //마우스 이동시 실행
            {
                StopScreenSaver();
            }
        }
        private void StopScreenSaver()
        {
            if (LKTime == true)
            {
                Cursor.Show();
                Timer.Enabled = false;
                Application.Exit();
            }
            else
            {
                Form2 frm2 = new Form2();
                Cursor.Show();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    mXStart = 0;
                    mYStart = 0;
                    LkSreen = true;
                }
            }
        }

        private void pbImg_MouseMove(object sender, MouseEventArgs e)
        {
            if(LkSreen == true)
            {
                if ((mXStart == 0) && (mYStart == 0)) //초기 포인터 설정
                {
                    mXStart = e.X;
                    mYStart = e.Y;
                    return;
                }
                else if ((e.X != mXStart) || (e.Y != mYStart)) //마우스 이동시 실행
                {
                    StopScreenSaver();
                }
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (LkSreen == true)
            {
                if ((mXStart == 0) && (mYStart == 0)) //초기 포인터 설정
                {
                    mXStart = e.X;
                    mYStart = e.Y;
                    return;
                }
                else if ((e.X != mXStart) || (e.Y != mYStart)) //마우스 이동시 실행
                {
                    StopScreenSaver();
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (LkSreen == true)
            {
                StopScreenSaver();
            }
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            LKTime = false;
            this.LockTimer.Enabled = false;
        }
    }
}