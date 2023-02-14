using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace mook_PreventKill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread ProcCheck = null;
        bool Start = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            ProcCheck = new Thread(ProcKill);
            ProcCheck.Start();
        }
        private void ProcKill()
        {
            while(Start)
            {
                var tproc = Process.GetProcessesByName("mook_PreventKillAgent");
                if (tproc.Length == 1) { }
                else
                {
                    var proc = new Process();
                    proc.StartInfo.FileName = "mook_PreventKillAgent.exe";
                    proc.Start();
                }
            }
        }
    }
}
