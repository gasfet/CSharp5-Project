using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_WinControl01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                this.lblResult.Text = "로그인 성공";
            }
        }
        private bool CheckData()
        {
            if (this.txtId.Text == "")
            {
                MessageBox.Show("로그인 아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtId.Focus();
                return false;
            }
            else if (this.txtPwd.Text == "")
            {
                MessageBox.Show("로그인 비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPwd.Focus();
                return false;
            }
            else
            {
                if (this.txtId.Text == "test")
                {
                    if (this.txtPwd.Text == "1234")
                        return true;
                    else
                    {
                        this.lblResult.Text = "일치하는 비밀번호가 없습니다.";
                        this.txtPwd.Focus();
                        return false;
                    }
                }
                else
                {
                    this.lblResult.Text = "일치하는 아이디가 없습니다.";
                    this.txtId.Focus();
                    return false;
                }
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckData() == true)
                {
                    this.lblResult.Text = "로그인 성공";
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
