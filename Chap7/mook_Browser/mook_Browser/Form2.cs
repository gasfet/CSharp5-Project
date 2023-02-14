using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //파일 클래스 사용
using Microsoft.Win32; //레지스터 클래스 사용

namespace mook_Browser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String htmlFileName; //파일 경로
        FileStream fs; //객체 생성
        RegistryKey regKey = Registry.CurrentUser; //레지스트리 클래스 선언
        private void Form2_Load(object sender, EventArgs e)
        {
            this.cbAddress.Items.Clear(); //items 속성 값 초기화
            var R_URL = regKey.OpenSubKey("Software\\Microsoft\\Internet Explorer\\TypedURLs"); //하위 레지스트리 키 대입
            foreach (var reg in R_URL.GetValueNames())
            {
                this.cbAddress.Items.Add(R_URL.GetValue(reg.ToString()).ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 닫기
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.ofdHtml.Filter = "웹 문서 (*.html) | *.html|(*.htm) | *.htm";
            this.ofdHtml.ShowDialog();
            htmlFileName = this.ofdHtml.FileName;
            this.cbAddress.Text = htmlFileName;
            if (htmlFileName != String.Empty)
            {
                fs = new FileStream(htmlFileName, FileMode.Open);
                this.ofdHtml.Reset();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.webBrowser.DocumentStream = fs;
        }
    }
}
