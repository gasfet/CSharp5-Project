using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; //레지스트리 클래스 사용

namespace mook_Browser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        RegistryKey regKey = Registry.CurrentUser; //레지스트리 클래스의 객체 선언

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = "http://www.microsoft.com/isapi/redir.dll?prd=ie&pver=6&ar=msnhome"; //기본 페이지 설정
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = "about:blank"; // 빈페이지 설정
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text == "")
            {
                MessageBox.Show("페이지를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var key = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main", true);
                var url = this.txtAddress.Text;
                key.SetValue("Start Page", url); // 레지스트리 인터넷 시작 주소 설정 
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var key = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
            this.txtAddress.Text = key.GetValue("Start Page").ToString(); // 레지스트리 인터넷 시작 주소 조회
        }
    }
}