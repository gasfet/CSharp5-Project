using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace mook_PortScanner
{
    public partial class Form1 : Form
    {
        private IPAddress scanIp = null;
        private string strFile = null;
        Thread PortScan = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.fbdFile.ShowDialog() == DialogResult.OK)
                strFile = this.fbdFile.SelectedPath + @"\포트스캔("
                    + this.txtIp.Text + ").txt";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (strFile != null)
            {
                this.pgbScan.Minimum = Convert.ToInt32(this.txtStart.Text);
                this.pgbScan.Maximum = Convert.ToInt32(this.txtEnd.Text);
                this.btnStart.Enabled = false;
                this.btnFile.Enabled = false;
                PortScan = new Thread(PortScanner);
                PortScan.Start();
            }
        }
        private void PortScanner()
        {
            int i, intstart, intend;

            this.lblFile.Text = "생성파일 : " + strFile;

            StreamWriter sw = new StreamWriter(strFile);

            scanIp = IPAddress.Parse(this.txtIp.Text);
            intstart = Convert.ToInt32(this.txtStart.Text);
            intend = Convert.ToInt32(this.txtEnd.Text);

            sw.WriteLine("************ 스캔 시작 ************ " 
                + DateTime.Now);
            sw.WriteLine();
            for (i = intstart; i <= intend; i++)
            {
                this.pgbScan.Value = i;
                try
                {
                    IPEndPoint endpoint = new IPEndPoint(scanIp, i);
                    Socket sSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);
                    sSocket.Connect(endpoint);
                    sw.WriteLine("ScanPort {0} 열려있음", i);
                    this.lvScan.Items.Add(new ListViewItem(new 
                        string[] {i.ToString(), "open" }));
                    continue;
                }
                catch (SocketException ex)
                {
                    if (ex.ErrorCode != 10061)
                        sw.WriteLine("에러 : {0}", ex.Message);
                }
                sw.WriteLine("ScanPort {0} 닫혀있음", i);
                this.lvScan.Items.Add(new ListViewItem(new
                    string[] { i.ToString(), "close" }));
            }
            sw.WriteLine();
            sw.WriteLine("************ 스캔 종료 ************ " + DateTime.Now);
            sw.Close();

            this.btnStart.Enabled = true;
            this.btnFile.Enabled = true;
            MessageBox.Show("포트 스캔을 완료하였습니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = strFile;
            myProcess.Start();
            PortScan.Abort();
         }
    }
}
