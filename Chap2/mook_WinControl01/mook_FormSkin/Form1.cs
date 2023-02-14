using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_FormSkin
{
    public partial class Form1 : Form
    {
        private bool SpeakerBarMouseDown = false;
        private bool FormMouseDown = false;
        private bool SpeakerOn = true;

        private const int SPEKAERBAR_XPOS = 128; //트랙바 Left
        private const int SPEKAERBAR_YPOS = 123; //트랙바 높이
        private const int SPEKAERBAR_WIDTH = 74; //트랙바 사이즈

        private string BackPath = @"..\..\main1"; //스킨 이미지 파일 경로
        private bool BackChange = false;

        Point ptMouseCurrentPos; // 마우스 클릭 좌표 지정
        Point ptMouseNewPos; // 이동시 마우스 좌표
        Point ptFormCurrentPos; // 폼 위치 좌표 지정
        Point ptFormNewPos; // 이동시 폼 위치 좌표


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            FormDisplay();
        }

        private void FormDisplay()
        {
            this.BackgroundImage = Image.FromFile(BackPath + @"\MainBack.jpg");
            picSpeakerTrack.Image = Image.FromFile(BackPath + @"\SpeakerTrack.jpg");
            picClose.Image = Image.FromFile(BackPath + @"\Close_Normal01.jpg");
            picMinimize.Image = Image.FromFile(BackPath + @"\Minimize_Normal01.jpg");
            picPlay.Image = Image.FromFile(BackPath + @"\Play_Normal01.jpg");
            picPause.Image = Image.FromFile(BackPath + @"\Pause_Normal01.jpg");
            picStop.Image = Image.FromFile(BackPath + @"\Stop_Normal01.jpg");
            picFileOpen.Image = Image.FromFile(BackPath + @"\FileOpen_Normal01.jpg");
            picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerON_Normal01.jpg");
        }

        private void picSpeakerTrack_MouseDown(object sender, MouseEventArgs e)
        {
            SpeakerBarMouseDown = true;
        }

        private void picSpeakerTrack_MouseUp(object sender, MouseEventArgs e)
        {
            SpeakerBarMouseDown = false;
        }

        private void picSpeakerTrack_MouseMove(object sender, MouseEventArgs e)
        {
            if (SpeakerBarMouseDown)
            {
                if (picSpeakerTrack.Left >= SPEKAERBAR_XPOS && picSpeakerTrack.Left <= SPEKAERBAR_XPOS + SPEKAERBAR_WIDTH)
                {
                    if (e.X > 0) picSpeakerTrack.Left = picSpeakerTrack.Left + 1;
                    else picSpeakerTrack.Left = picSpeakerTrack.Left - 1;
                    picSpeakerShow();
                }

                if (picSpeakerTrack.Left <= SPEKAERBAR_XPOS)
                {
                    picSpeakerTrack.Left = SPEKAERBAR_XPOS;

                    SpeakerOn = false;
                    picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerOFF_Normal01.jpg");
                }
                if (picSpeakerTrack.Left >= SPEKAERBAR_XPOS + SPEKAERBAR_WIDTH)
                {
                    picSpeakerTrack.Left = SPEKAERBAR_XPOS + SPEKAERBAR_WIDTH;
                    picSpeakerShow();
                }
                this.lblVolume.Text = "Volume : " + (((picSpeakerTrack.Left - 128) * 100 / SPEKAERBAR_WIDTH)).ToString() + "%";
            }
        }

        private void picSpeakerShow()
        {
            SpeakerOn = true;
            picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerON_Normal01.jpg");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            picMinimize.Image = Image.FromFile(BackPath + @"\Minimize_Down01.jpg");
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.Image = Image.FromFile(BackPath + @"\Minimize_Normal01.jpg");
        }

        private void picMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            picMinimize.Image = Image.FromFile(BackPath + @"\Minimize_Over01.jpg");
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            picClose.Image = Image.FromFile(BackPath + @"\Close_Down01.jpg");
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Image.FromFile(BackPath + @"\Close_Normal01.jpg");
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Image.FromFile(BackPath + @"\Close_Over01.jpg");
        }

        private void 표준ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackPath = @"..\..\main1";
            BackChange = true;
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            Invalidate();
        }

        private void 가벼운ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackPath = @"..\..\main2";
            BackChange = true;
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(52)))));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(52)))));

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (BackChange)
            {
                FormDisplay();
                BackChange = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormMouseDown = true; // 왼쪽 마우스 클릭 체크
                ptMouseCurrentPos = Control.MousePosition; // 마우스 클릭 좌표
                ptFormCurrentPos = this.Location; // 폼의 위치 좌표
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                FormMouseDown = false; // 왼쪽 마우스 클릭 해체 체크
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormMouseDown == true) // 왼쪽 마우스 클릭시
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X; //마우스 이동시 가로 좌표
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y; //마우스 이동시 세로 좌표
                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }

        private void picPlay_MouseDown(object sender, MouseEventArgs e)
        {
            picPlay.Image = Image.FromFile(BackPath + @"\Play_Down01.jpg");
        }

        private void picPlay_MouseLeave(object sender, EventArgs e)
        {
            picPlay.Image = Image.FromFile(BackPath + @"\Play_Normal01.jpg");
        }

        private void picPlay_MouseMove(object sender, MouseEventArgs e)
        {
            picPlay.Image =  Image.FromFile(BackPath + @"\Play_Over01.jpg");
        }

        private void picPause_MouseDown(object sender, MouseEventArgs e)
        {
            picPause.Image =  Image.FromFile(BackPath + @"\Pause_Down01.jpg");
        }

        private void picPause_MouseLeave(object sender, EventArgs e)
        {
            picPause.Image = Image.FromFile(BackPath + @"\Pause_Normal01.jpg");
        }

        private void picPause_MouseMove(object sender, MouseEventArgs e)
        {
            picPause.Image = Image.FromFile(BackPath + @"\Pause_Over01.jpg");
        }

        private void picStop_MouseDown(object sender, MouseEventArgs e)
        {
            picStop.Image = Image.FromFile(BackPath + @"\Stop_Down01.jpg");
        }

        private void picStop_MouseLeave(object sender, EventArgs e)
        {
            picStop.Image = Image.FromFile(BackPath + @"\Stop_Normal01.jpg");
        }

        private void picStop_MouseMove(object sender, MouseEventArgs e)
        {
            picStop.Image = Image.FromFile(BackPath + @"\Stop_Over01.jpg");
        }

        private void picFileOpen_MouseLeave(object sender, EventArgs e)
        {
            picFileOpen.Image = Image.FromFile(BackPath + @"\FileOpen_Normal01.jpg");
        }

        private void picFileOpen_MouseMove(object sender, MouseEventArgs e)
        {
            picFileOpen.Image = Image.FromFile(BackPath + @"\FileOpen_Over01.jpg");
        }

        private void picFileOpen_MouseDown(object sender, MouseEventArgs e)
        {
            picFileOpen.Image = Image.FromFile(BackPath + @"\FileOpen_Down01.jpg");;
        }

        private void picSpeaker_MouseLeave(object sender, EventArgs e)
        {
            if (SpeakerOn)
            {
                picSpeaker.Image = Image.FromFile( BackPath + @"\SpeakerON_Normal01.jpg");
            }
            else
            {
                picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerOFF_Normal01.jpg");
            }
        }

        private void picSpeaker_MouseMove(object sender, MouseEventArgs e)
        {
            if (SpeakerOn)
            {
                picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerON_Over01.jpg");
            }
            else
            {
                picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerOFF_Over01.jpg");
            }
        }

        private void picSpeaker_MouseDown(object sender, MouseEventArgs e)
        {
            if (SpeakerOn)
            {
                SpeakerOn = false;
                picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerOFF_Over01.jpg");
            }
            else
            {
                SpeakerOn = true;
                picSpeaker.Image = Image.FromFile(BackPath + @"\SpeakerOn_Over01.jpg");
            }
        }
    }
}
