using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //파일클래스사용
using System.Data.SqlClient; //SqlConnection 클래스사용

namespace mook_AutoAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileInfo f = null; //파일정보검색
        string Constr = "server=localhost;uid=sa;pwd=p12345;database=mook"; //서버연결문자열
        string FileName = "";
        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.txtFile.Text = this.ofdFile.FileName;
                    f = new FileInfo(this.ofdFile.FileName);
                    this.lbldisName.Text = f.Name;
                    this.FileName = f.Name;
                    this.lbldisSize.Text = f.Length.ToString() + " byte";
                    this.lbldisDate.Text = f.LastWriteTime.ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var fs = f.OpenRead();
            var bytebuffer = new byte[fs.Length];
            fs.Read(bytebuffer, 0, Convert.ToInt32(fs.Length));

            var conn = new SqlConnection(Constr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            var Sql = "update Table_File set M_File=@M_File, M_FileName = '" + 
                this.FileName + "' where M_Num=1";


            cmd.CommandText = Sql;
            cmd.Parameters.Add(new SqlParameter("@M_File", 
                System.Data.SqlDbType.Image)).Value = bytebuffer;
            var iResult = cmd.ExecuteNonQuery();
            conn.Close();
            fs.Close();
            if ((iResult > 0) && (DataSave() > 0))
            {
                MessageBox.Show("저장이 정상적으로 되었습니다.", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("저장이 되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int DataSave()
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();
            var strSQL = "update Table_Update set M_Date=M_Date+1";
            var myCom = new SqlCommand(strSQL, Conn);
            var i = myCom.ExecuteNonQuery();
            Conn.Close();
            return i;
        }
    }
}

