using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // 파일 클래스 사용

namespace mook_TypingWord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ReturnStep //게임 단위 선택
        {
            get { return this.cbGrade.Text; }
        }
        public string ReturnKind //한글 및 영어 옵션 선택
        {
            get { return this.cbKind.Text; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cbKind.Text = "한글";
            lvWordView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (this.txtInsert.Text == "")
            {
                this.txtInsert.Focus();
            }
            else
            {
                string str = this.txtInsert.Text;
                var dlr = MessageBox.Show("" + str + "을 저장합니다..", 
                    "저장하기", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (dlr)
                {
                    case DialogResult.Yes:
                        var f = new FileInfo(@"setup.txt");
                        if (f.Exists == true)
                        {
                            var sw = new StreamWriter(new FileStream(@"setup.txt", FileMode.Append));
                            var s = "";
                            if (this.cbKind.Text == "영어") { s = "2" + "&" + this.txtInsert.Text; }
                            else { s = "1" + "&" + this.txtInsert.Text; }
                            sw.WriteLine(s);
                            sw.Close();
                            this.lvWord.Items.Add(this.txtInsert.Text);
                        }
                        else
                        {
                            var sw = File.CreateText(@"setup.txt");
                            var s = "";
                            if (this.cbKind.Text == "영어") { s = "2" + "&" + this.txtInsert.Text; }
                            else { s = "1" + "&" + this.txtInsert.Text; }
                            sw.WriteLine(s);
                            sw.Close();
                            this.lvWord.Items.Add(this.txtInsert.Text);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
                this.txtInsert.Text = "";
                this.txtInsert.Focus();
            }
        }

        private void cbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvWordView();
        }

        private void lvWordView()
        {
            this.lvWord.Items.Clear();
            var f = new FileInfo(@"setup.txt");
            if (f.Exists == true)
            {
                var sr = File.OpenText(@"setup.txt");
                while (true)
                {
                    var str = sr.ReadLine();
                    if (str == null) break;
                    var a_str = str.Split('&');
                    if (this.cbKind.SelectedItem.ToString() == "한글")
                    {
                        if (a_str[0] == "1") { this.lvWord.Items.Add(a_str[1]); }
                    }
                    else
                    {
                        if (a_str[0] == "2") { this.lvWord.Items.Add(a_str[1]); }
                    }
                }
                sr.Close();
            }
            else
            {
                var sw = new StreamWriter(new FileStream(@"setup.txt", FileMode.CreateNew));
                sw.Close();
                MessageBox.Show("에러 발생\n 파일을 생성합니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
