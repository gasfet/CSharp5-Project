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
using System.Threading;

namespace mook_HiddenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadFileView = null;

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvFile.Items.Clear();
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }
        private void FileView(object filepath)
        {
            DirectoryInfo di = new DirectoryInfo(filepath.ToString());
            FileInfo[] fi = di.GetFiles();
            DirectoryInfo[] dti = di.GetDirectories();

            foreach (FileInfo f in fi)
            {
                if (this.rbtnAll.Checked == true)
                {
                    var lvt = new ListViewItem(new string[] { 
                        f.Name, f.Length.ToString(), f.CreationTime.ToString() });
                    this.lvFile.Items.Add(lvt);
                }
                else
                {
                    if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        var lvt = new ListViewItem(new string[] { 
                            f.Name, f.Length.ToString(), f.CreationTime.ToString() });
                        this.lvFile.Items.Add(lvt);
                    }
                }
            }

            for (int i = 0; i < dti.Length;i++)
            {
                FileView(dti[i].FullName);
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (threadFileView != null)
                threadFileView.Abort();
            if (this.txtPath.Text != "") 
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (threadFileView != null)
                threadFileView.Abort();
            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }
    }
}
