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
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace mook_NetStat
{
    public partial class Form1 : Form
    {
        IPGlobalProperties ipProperties = 
            IPGlobalProperties.GetIPGlobalProperties();
        Thread NetThread = null;
        string LocPort, RemoAdd, RemoPort;
        bool CheckBool = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetThread = new Thread(NetView);
            NetThread.Start();
        }

        private void NetView()
        {
            while(true)
            {
                this.CheckBool = true;
                NCheck();
                this.lvNetState.Items.Clear();
                TcpConnectionInformation[] tcpConnections = 
                ipProperties.GetActiveTcpConnections();
                int i = 0;
                foreach(TcpConnectionInformation NetInfo in tcpConnections)
                {
                    this.lvNetState.Items.Add(NetInfo.LocalEndPoint.Address.ToString());
                    this.lvNetState.Items[i].SubItems.Add(NetInfo.LocalEndPoint.Port.ToString());
                    this.lvNetState.Items[i].SubItems.Add(NetInfo.RemoteEndPoint.Address.ToString());
                    this.lvNetState.Items[i].SubItems.Add(NetInfo.RemoteEndPoint.Port.ToString());
                    this.lvNetState.Items[i].SubItems.Add(NetInfo.State.ToString());

                    if (NetInfo.LocalEndPoint.Port.ToString() == LocPort)
                        this.lvNetState.Items[i].SubItems[0].BackColor = Color.GreenYellow;
                    if (NetInfo.RemoteEndPoint.Address.ToString() == RemoAdd)
                        this.lvNetState.Items[i].SubItems[0].BackColor = Color.LightPink;
                    if (NetInfo.RemoteEndPoint.Port.ToString() == RemoPort)
                        this.lvNetState.Items[i].SubItems[0].BackColor = Color.Aqua;
                    i++;
                }
                this.CheckBool = false;
                NCheck();
                Thread.Sleep(30000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NetThread != null)
                NetThread.Abort();
            Application.ExitThread();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.LocPort = this.txtLocPort.Text;
            this.RemoAdd = this.txtForAdd.Text;
            this.RemoPort = this.txtForPort.Text;
            NCheck();
        }
        private void NCheck()
        {
            if (CheckBool)
            {
                this.txtLocPort.Enabled = false;
                this.txtForPort.Enabled = false;
                this.txtForAdd.Enabled = false;
                this.btnCheck.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtLocPort.Enabled = true;
                this.txtForPort.Enabled = true;
                this.txtForAdd.Enabled = true;
                this.btnCheck.Enabled = true;
                this.btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(this.sfdFile.FileName);
                sw.WriteLine("파일생성 : " +  DateTime.Now);
                sw.WriteLine();
                sw.WriteLine("로컬주소	로컬포트	외부주소	외부포트	상태");
                for(int i =0 ; i < this.lvNetState.Items.Count -1 ; i++)
                {
                    sw.WriteLine(this.lvNetState.Items[i].SubItems[0].Text + "	" +
                        this.lvNetState.Items[i].SubItems[1].Text + "	" +
                        this.lvNetState.Items[i].SubItems[2].Text + "	" +
                        this.lvNetState.Items[i].SubItems[3].Text + "	" +
                        this.lvNetState.Items[i].SubItems[4].Text);
                }
                sw.WriteLine();
                sw.WriteLine("파일생성 종료 : " + DateTime.Now);
                sw.Close();
            }
        }
    }
}