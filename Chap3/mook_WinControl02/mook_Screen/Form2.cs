using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Screen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtPwd.Focus();
            Form1.LkSreen = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.txtPwd.Focus();
            this.txtPwd.Clear();
            DialogResult = DialogResult.OK;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text == "1234")
            {
                Cursor.Show();
                Application.ExitThread();
            }
            else
            {
                this.lblResult.Text = "비밀번호 오류";
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if(this.txtPwd.Text == "1234")
                {
                    Cursor.Show();
                    Application.ExitThread();
                }
                else
                    this.lblResult.Text = "비밀번호 오류";
            }
        }
    }
}
