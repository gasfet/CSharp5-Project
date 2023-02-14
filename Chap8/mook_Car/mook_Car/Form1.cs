using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mook_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string StrSQL = "Data Source=localhost;Database=mook;User Id=root;Password=p12345"; //데이터베이스 연결 문자열
        private string Data_Num; // 선택된 lvList 컨트롤 행의 값 저장
        private void Form1_Load(object sender, EventArgs e)
        {
            lvList_MySqlClient_View();
        }

        private void lvList_MySqlClient_View()
        {
            this.lvList.Items.Clear();
            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            var Comm = new MySqlCommand("Select * From CarInfo", MConn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["M_Num"].ToString(), 
                    myRead["M_Name"].ToString(), myRead["M_Year"].ToString(), 
                    myRead["M_Price"].ToString(), myRead["M_Door"].ToString() };
                var lvt = new ListViewItem(strArray);
                this.lvList.Items.Add(lvt);
            }
            myRead.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtYear.Text != "" 
                && this.txtPrice.Text != "" && this.txtDoor.Text != "")
            {
                var Conn = new MySqlConnection(StrSQL);
                Conn.Open();
                string Sql = "insert into CarInfo(M_Name, M_Year, M_Price, M_Door) values('";
                Sql += this.txtName.Text + "'," + this.txtYear.Text + ",'" + 
                    this.txtPrice.Text + "'," + this.txtDoor.Text + ")";
                var Comm = new MySqlCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_MySqlClient_View();
                    Control_Clear();
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Control_Clear()
        {
            this.txtName.Clear();
            this.txtYear.Clear();
            this.txtPrice.Clear();
            this.txtDoor.Clear();
        }

        private void lvList_Click(object sender, EventArgs e)
        {
            this.txtName.Text = this.lvList.SelectedItems[0].SubItems[1].Text;
            this.txtYear.Text = this.lvList.SelectedItems[0].SubItems[2].Text;
            this.txtPrice.Text = this.lvList.SelectedItems[0].SubItems[3].Text;
            this.txtDoor.Text = this.lvList.SelectedItems[0].SubItems[4].Text;
            Data_Num = this.lvList.SelectedItems[0].SubItems[0].Text;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtYear.Text != "" && 
                this.txtPrice.Text != "" && this.txtDoor.Text != "")
            {
                try
                {
                    var Conn = new MySqlConnection(StrSQL);
                    Conn.Open();

                    var MySqlAdapter = new MySqlDataAdapter("select * from CarInfo", Conn);

                    var ds = new DataSet();
                    MySqlAdapter.Fill(ds, "dsTable");
                    var dt = ds.Tables["dsTable"].Select("M_Num =" + Convert.ToInt32(this.Data_Num), 
                        null, DataViewRowState.CurrentRows);

                    DataRow drTemp;
                    drTemp = dt[0];
                    drTemp["M_Name"] = this.txtName.Text;
                    drTemp["M_Year"] = this.txtYear.Text;
                    drTemp["M_Price"] = this.txtPrice.Text;
                    drTemp["M_Door"] = this.txtDoor.Text;

                    var cmdBuild = new MySqlCommandBuilder(MySqlAdapter);
                    MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
                    MySqlAdapter.Update(ds, "dsTable");
                    cmdBuild.Dispose();

                    MessageBox.Show("정상적으로 데이터가 수정되었습니다.", "알림", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_MySqlClient_View();
                    Control_Clear();
                }
                catch
                {
                    MessageBox.Show("정상적으로 데이터가 수정되지 않았습니다.", "에러", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

