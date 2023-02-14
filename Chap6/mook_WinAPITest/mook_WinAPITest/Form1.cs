using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //DllImportAttribute 클래스 이용

namespace mook_WinAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        private static extern int Beep(int dwFreq, int dwDuration);

        [DllImport("User32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);
        bool flashbool = false;

        [DllImport("winmm.dll")]
        private static extern int mciSendStringA(string Cmd, int RetVal, int RetLen,
            int RetInt);
        bool CDStatus = false;

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (CDStatus == false)
            {
                mciSendStringA("set CDAudio door open", 0, 0, 0);
                CDStatus = true;
                this.lblStatus.Text = "OPEN";
                this.btnStatus.Text = "CDR OPEN";
            }
            else
            {
                mciSendStringA("set CDAudio door closed", 0, 0, 0);
                CDStatus = true;
                this.lblStatus.Text = "CLOSE";
                this.btnStatus.Text = "CDR CLOSE";
            }
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            if (flashbool == false)
            {
                flashbool = true;
                this.btnFlash.Text = "Flash ON";
                this.Timer.Interval = this.hsbFlash.Value;
                this.Timer.Enabled = true;
            }
            else
            {
                flashbool = false;
                this.btnFlash.Text = "Flash OFF";
                this.Timer.Interval = this.hsbFlash.Value;
                this.Timer.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FlashWindow(this.Handle, true);
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            Beep(this.tkbSound.Value, this.tkbLength.Value);
        }
    }
}
