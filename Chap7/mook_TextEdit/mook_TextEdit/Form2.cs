using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mook_TextEdit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Boolean txtNoteChange = false; //내용 변경 체크
        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            this.txtNoteChange = true;
        }

        private void 글자모양ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontdlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.Font = this.fontdlg.Font;
            }
        }

        private void 글자색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.colordlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.ForeColor = this.colordlg.Color;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (this.txtNoteChange == true)
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dlr)
                {
                    case DialogResult.Yes:
                        var dr = this.sfdFile.ShowDialog();
                        if (dr != DialogResult.Cancel)
                        {
                            var str = this.sfdFile.FileName;
                            var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                            sw.Write(this.rtbText.Text);
                            sw.Flush();
                            sw.Close();
                            this.txtNoteChange = false;
                        }
                        this.Dispose();
                        break;
                    case DialogResult.No:
                        this.Dispose();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rtbText.AllowDrop = true;
            rtbText.DragDrop += new DragEventHandler(rtbText_DragDrop);
        }

        private void rtbText_DragDrop(object sender, DragEventArgs e)
        {
            string file = (string)e.Data.GetData(DataFormats.Text);

            StreamReader sr = new StreamReader(file, System.Text.Encoding.Default);
            rtbText.Text = sr.ReadToEnd();
            sr.Close();

            this.Text = file;
        }
    }
}