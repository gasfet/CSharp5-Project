using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Gugudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResult.Items.Clear();

            var s = this.cbbSelect.SelectedItem.ToString();
            var gustr = s.Split(new char[] { ' ' });

            this.lbResult.Items.Add(gustr[0] + "단 실행 결과");
            this.lbResult.Items.Add("");
            this.lbResult.Items.Add("");

            for (var i = 1; i < 10; i++)
            {
                this.lbResult.Items.Add(gustr[0] + " * " + i.ToString() + " = " + (Convert.ToInt32(gustr[0]) * i).ToString());
            }
        }
    }
}
