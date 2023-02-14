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
using Shell32;
using System.Runtime.InteropServices;

namespace mook_FileRestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000002,
            SHERB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, 
            string pszRootPath, RecycleFlags dwFlags);

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_RecycleBinFile();
        }

        private void Load_RecycleBinFile()
        {
            this.lvRcbFile.Items.Clear();
            Shell Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);
            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName 
                    += Path.GetExtension(FI.Path);
                string FilePath = Recycler.GetDetailsOf(FI, 1);
                string FileDelDate = Recycler.GetDetailsOf(FI, 2);
                var lvt = new ListViewItem(new string[] { 
                        FileName, FilePath,FileDelDate });
                this.lvRcbFile.Items.Add(lvt);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_RecycleBinFile();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION);
                MessageBox.Show(this, "휴지통을 비웠습니다.", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "휴지통 비우는 작업이 실패하였습니다." 
                    + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            finally
            {
                Load_RecycleBinFile();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.lvRcbFile.SelectedItems.Count != 0)
            {
                FileRestore(this.lvRcbFile.SelectedItems[0].SubItems[1].Text 
                    + @"\" + this.lvRcbFile.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                MessageBox.Show("복원할 파일을 선택하세요", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool FileRestore(string Item)
        {
            Shell shl = new Shell();
            Folder Recycler = shl.NameSpace(10);
            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName 
                    += Path.GetExtension(FI.Path);
                string FilePath = Recycler.GetDetailsOf(FI, 1);

                if (Item == Path.Combine(FilePath, FileName))
                {
                    DoVerb(FI, "복원(&E)");
                    return true;
                }
            }
            return false;
        }

        private bool DoVerb(FolderItem Item, string Verb)
        {
            foreach (FolderItemVerb FIVerb in Item.Verbs())
            {
                if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    FIVerb.DoIt();
                    Load_RecycleBinFile();
                    return true;
                }
            }
            return false;
        }
    }
}
