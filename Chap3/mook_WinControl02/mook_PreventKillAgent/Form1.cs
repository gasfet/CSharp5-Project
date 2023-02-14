using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mook_PreventKillAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 종료EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleChange(true, false);
            var tproc = Process.GetProcessesByName("mook_PreventKill");
            if (tproc.Length == 0)
            {
                var proc = new Process();
                proc.StartInfo.FileName = "mook_PreventKill.exe";
                proc.Start();
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            var tproc = Process.GetProcessesByName("mook_PreventKill");
            if (tproc.Length == 1)
                tproc[0].Kill();
            this.Dispose();
            Application.Exit();
        }
    }
}

