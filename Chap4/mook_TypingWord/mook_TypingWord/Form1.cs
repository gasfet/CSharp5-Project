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
using System.Collections; //ArrayList 클래스 사용

namespace mook_TypingWord
{
    public partial class Form1 : Form
    {
        private string kind = ""; //한글 또는 영어
        int array = 0; //랜덤 수 지정
        int jumsu = 0; //점수
        int selectlbl; //1~6 랜덤 수(랜덤벽돌 지정)
        int maxjumsu = 0; //최종점수
        private string[] word; //배열에 워드 지정
        private string[] TempKorWord = new string[] {"가나다", "라마바", "아자차", "카파하", "도레미", "파솔라"}; //배열에 워드 지정 
        private string[] TempEnWord = new string[] {"abc", "def", "ghi", "jkl", "mno", "pqr"}; //배열에 워드 지정
        private ArrayList ArrayWord = new ArrayList(); //맞춰질 문자 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                this.lblGrade.Text = frm2.ReturnStep;
                kind = frm2.ReturnKind;
            }
        }

        private void 사용자설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3(); //폼2 개체 생성
            if (frm3.ShowDialog() == DialogResult.OK) //폼2의 버튼 클릭 결과 여부 확인
            {

                this.lblName.Text = frm3.ReturnName; //폼2의 get 접근자 변수값 엑세스
                if (frm3.checkNum == 1)
                {
                    this.lblImg.ImageIndex = 0;
                }
                else
                {
                    this.lblImg.ImageIndex = 1;
                }
                this.lblImg.Text = "";
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var Rekind = 0;
            if (File.Exists("setup.txt") == false)
            {
                MessageBox.Show("단어가 없어 기본 게임으로 시작합니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (kind == "한글")
                    word = TempKorWord;
                else
                    word = TempEnWord;
                array = word.Length;
            }
            else
            {
                if (kind == "한글") { Rekind = 1; }
                else if (kind == "영어") { Rekind = 2; }
                else { Rekind = 1; }

                var srt = File.OpenText(@"setup.txt");
                while (true)
                {
                    var str = srt.ReadLine();
                    if (str == null) break;
                    var a_str = str.Split('&');
                    if (a_str[0] == Convert.ToString(Rekind))
                        ArrayWord.Add(a_str[1]);
                }
                array = ArrayWord.Count;
                srt.Close();

                if(ArrayWord.Count < 5)
                {
                    MessageBox.Show("단어가 적절하지 않아 기본 게임으로 시작합니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (kind == "한글")
                        word = TempKorWord;
                    else
                        word = TempEnWord;
                    array = word.Length;
                }
                else
                {
                    word = new string[ArrayWord.Count];
                    int i = 0;
                    foreach(string wd in ArrayWord)
                    {
                        word[i++] = wd;
                    }
                }
            }

            this.lblLife.Width = 200;
            this.txtJumsu.Text = "0";

            MessageBox.Show("제 " + lblGrade.Text + "단계입니다...");
            this.txtInsert.Focus();


            if (randomtim.Enabled == false)
            {
                randomtim.Enabled = true;
                var r = new Random();
                var i = r.Next(0, array - 4);
                this.button1.Text = word[i];
                this.button2.Text = word[i + 1];
                this.button3.Text = word[i + 2];
                this.button4.Text = word[i + 3];
                this.button5.Text = word[i + 4];
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //종료 중지 코드
            var dlr = MessageBox.Show("폼을 종료합니다.", 
                "끝내기", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (dlr)
            {
                case DialogResult.Yes:
                    Application.ExitThread(); //폼 종료
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.randomtim.Enabled = false;
            this.btn1tim.Enabled = false;
            this.btn2tim.Enabled = false;
            this.btn3tim.Enabled = false;
            this.btn4tim.Enabled = false;
            this.btn5tim.Enabled = false;
            this.array = 0;

            try
            {
                if (Convert.ToInt32(this.txtJumsu.Text) > maxjumsu)
                {
                    this.txtMaxJumsu.Text = this.txtJumsu.Text;
                }
                this.txtJumsu.Text = "0";
                for (var i = 0; i < this.plMain.Controls.Count; i++)
                {
                    (this.plMain.Controls[i]).Top = -0;
                }
            }
            catch { }
        }

        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            var r = new Random();
            int randomtxt;
            if (e.KeyCode == Keys.Enter)
            {
                for (var i = 0; i < this.plMain.Controls.Count; i++)
                {
                    if (this.txtInsert.Text == (this.plMain.Controls[i]).Text)
                    {
                        randomtxt = r.Next(0, array);
                        (this.plMain.Controls[i]).Text = this.word[randomtxt];
                        jumsu += 10;
                        (this.plMain.Controls[i]).Top = -0;
                        this.txtJumsu.Text = Convert.ToString(jumsu);
                    }

                }
                this.txtInsert.Text = "";
            }
        }

        private void randomtim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            selectlbl = r.Next(1, 6);
            switch (selectlbl)
            {
                case 1:
                    this.btn1tim.Enabled = true;
                    break;
                case 2:
                    this.btn2tim.Enabled = true;
                    break;
                case 3:
                    this.btn3tim.Enabled = true;
                    break;
                case 4:
                    this.btn4tim.Enabled = true;
                    break;
                case 5:
                    this.btn5tim.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btn1tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);

            if ((this.plMain.Controls[0]).Top <= this.plMain.Height - (this.plMain.Controls[0]).Height)
            {
                (this.plMain.Controls[0]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[0]).Top = -0;
                (this.plMain.Controls[0]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
            }
        }

        private void btn2tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);

            if ((this.plMain.Controls[1]).Top <= this.plMain.Height - (this.plMain.Controls[1]).Height)
            {
                (this.plMain.Controls[1]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[1]).Top = -0;
                (this.plMain.Controls[1]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
            }
        }

        private void btn3tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);

            if ((this.plMain.Controls[2]).Top <= this.plMain.Height - (this.plMain.Controls[2]).Height)
            {
                (this.plMain.Controls[2]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[2]).Top = -0;
                (this.plMain.Controls[2]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
            }
        }

        private void btn4tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);

            if ((this.plMain.Controls[3]).Top <= this.plMain.Height - (this.plMain.Controls[3]).Height)
            {
                (this.plMain.Controls[3]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[3]).Top = -0;
                (this.plMain.Controls[3]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
            }
        }

        private void btn5tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);

            if ((this.plMain.Controls[4]).Top <= this.plMain.Height - (this.plMain.Controls[4]).Height)
            {
                (this.plMain.Controls[4]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[4]).Top = -0;
                (this.plMain.Controls[4]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
            }
        }

        private void lblLife_SizeChanged(object sender, EventArgs e)
        {
            if (lblLife.Width == 0)
            {
                randomtim.Enabled = false;
                btn1tim.Enabled = false;
                btn2tim.Enabled = false;
                btn3tim.Enabled = false;
                btn4tim.Enabled = false;
                btn5tim.Enabled = false;
                if (Convert.ToInt32(this.txtJumsu.Text) > maxjumsu)
                {
                    this.txtMaxJumsu.Text = this.txtJumsu.Text;
                }
                for (var i = 0; i < this.plMain.Controls.Count; i++)
                {
                    (this.plMain.Controls[i]).Top = -0;
                }
                this.txtJumsu.Text = "0";
                MessageBox.Show("넌 죽어쓰~~~~", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnStart.Focus();
            }
        }

        private void txtJumsu_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.txtJumsu.Text) != 0)
            {
                if (Convert.ToInt32(this.txtJumsu.Text) % 100 == 0)
                {

                    lblGrade.Text = Convert.ToString(Convert.ToInt32(lblGrade.Text) + 1);
                    for (int i = 0; i < this.plMain.Controls.Count; i++)
                    {
                        (this.plMain.Controls[i]).Top = -0;
                    }
                    btn1tim.Enabled = false;
                    btn2tim.Enabled = false;
                    btn3tim.Enabled = false;
                    btn4tim.Enabled = false;
                    btn5tim.Enabled = false;
                    this.txtInsert.Text = "";
                    this.txtInsert.Focus();
                }
            }
        }

        private void lblGrade_TextChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(lblGrade.Text))
            {
                case 1:
                    btn1tim.Interval = 1000;
                    btn2tim.Interval = 1000;
                    btn3tim.Interval = 1000;
                    btn4tim.Interval = 1000;
                    btn5tim.Interval = 1000;
                    break;
                case 2:
                    btn1tim.Interval = 900;
                    btn2tim.Interval = 900;
                    btn3tim.Interval = 900;
                    btn4tim.Interval = 900;
                    btn5tim.Interval = 900;
                    break;
                case 3:
                    btn1tim.Interval = 800;
                    btn2tim.Interval = 800;
                    btn3tim.Interval = 800;
                    btn4tim.Interval = 800;
                    btn5tim.Interval = 800;
                    break;
                case 4:
                    btn1tim.Interval = 700;
                    btn2tim.Interval = 700;
                    btn3tim.Interval = 700;
                    btn4tim.Interval = 700;
                    btn5tim.Interval = 700;
                    break;
                case 5:
                    btn1tim.Interval = 600;
                    btn2tim.Interval = 600;
                    btn3tim.Interval = 600;
                    btn4tim.Interval = 600;
                    btn5tim.Interval = 600;
                    break;
                case 6:
                    btn1tim.Interval = 500;
                    btn2tim.Interval = 500;
                    btn3tim.Interval = 500;
                    btn4tim.Interval = 500;
                    btn5tim.Interval = 500;
                    break;
                case 7:
                    btn1tim.Interval = 400;
                    btn2tim.Interval = 400;
                    btn3tim.Interval = 400;
                    btn4tim.Interval = 400;
                    btn5tim.Interval = 400;
                    break;
                case 8:
                    btn1tim.Interval = 300;
                    btn2tim.Interval = 300;
                    btn3tim.Interval = 300;
                    btn4tim.Interval = 300;
                    btn5tim.Interval = 300;
                    break;
                case 9:
                    btn1tim.Interval = 200;
                    btn2tim.Interval = 200;
                    btn3tim.Interval = 200;
                    btn4tim.Interval = 200;
                    btn5tim.Interval = 200;
                    break;
                case 10:
                    btn1tim.Interval = 110;
                    btn2tim.Interval = 110;
                    btn3tim.Interval = 110;
                    btn4tim.Interval = 110;
                    btn5tim.Interval = 110;
                    break;
                default:
                    btn1tim.Interval = 50;
                    btn2tim.Interval = 50;
                    btn3tim.Interval = 50;
                    btn4tim.Interval = 50;
                    btn5tim.Interval = 50;
                    break;
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}