using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation; //Ping, PingOptions 클래스 사용

namespace mook_NetCheck
{
    public partial class Form2 : Form
    {

        Ping pingSender = new Ping(); //Ping 클래스 개체 생성
        PingOptions options = new PingOptions(); //PingOptions 클래스 개체 생성
        public string StringIP = "";


        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //32비트 패킷 생성
        const int timeout = 120; //타임 아웃
        string[] args = new string[1]; //아이피 주소 입력


        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose(); //폼 종료
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            args[0] = StringIP;
            options.DontFragment = true;
            PingReply reply = pingSender.Send(args[0], timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                this.btnOk.Enabled = true;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //폼 종료 못하게
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true; //폼 실행시 [Timer] 컨트롤 활성화
        }
    }
}
