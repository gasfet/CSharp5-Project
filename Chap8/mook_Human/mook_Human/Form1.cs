using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // OleDbConnection, OleDbCommand 클래스 등 사용

namespace mook_Human
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Human.accdb;Mode=ReadWrite"; //데이터베이스 연결 문자열
        private string Human_Name, Human_Phone; // 선택된 lvList 컨트롤 행의 값 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Control_Check() == true)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string Sql = "INSERT INTO HumanInfo(M_Name, M_Age, M_Phone) VALUES('";
                Sql += this.txtName.Text + "','" + this.txtAge.Text + "', '" + 
                    this.txtCellPhone.Text + "')";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_OleDb_View();
                    Control_Clear();
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean Control_Check()
        {
            if (this.txtName.Text == "") // 이름 입력란 공백 체크
            {
                MessageBox.Show("이름을 입력하세요!!", "에러", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            else if (this.txtAge.Text == "") // 나이 입력란 공백 체크
            {
                MessageBox.Show("나이를 입력하세요!!", "에러", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            else if (this.txtCellPhone.Text == "") // 전화번호 입력란 공백 체크
            {
                MessageBox.Show("전화번호를 입력하세요!!", "에러", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.txtCellPhone.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Control_Clear() // 입력란 공백 처리
        {
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtCellPhone.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvList_OleDb_View();
        }

        private void lvList_OleDb_View()
        {
            this.lvList.Items.Clear();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var Comm = new OleDbCommand("SELECT * FROM HumanInfo", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["M_Name"].ToString(), 
                    myRead["M_Age"].ToString(), myRead["M_Phone"].ToString() };
                var lvt = new ListViewItem(strArray);
                this.lvList.Items.Add(lvt);
            }
            myRead.Close();
            Conn.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Control_Check() == true)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string Sql = "UPDATE HumanInfo SET M_Name ='" + 
                    this.txtName.Text + "', M_Age=" + 
                    Convert.ToInt32(this.txtAge.Text);
                Sql += ", M_Phone='" + this.txtCellPhone.Text + "'";
                Sql += "WHERE M_Name ='" + this.Human_Name + "' AND M_Phone ='" + 
                    this.Human_Phone + "'";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 수정되었습니다.", "알림", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_DataSet_View();
                    Control_Clear();
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터가 수정되지 않았습니다.", "에러", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lvList_DataSet_View()
        {
            this.lvList.Items.Clear();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var OleAdapter = new OleDbDataAdapter("SELECT * FROM HumanInfo", Conn);

            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("dsTable");
            OleAdapter.Fill(ds, "dsTable");

            IEnumerable<DataRow> query =
                from HumanInfo in dt.AsEnumerable()
                select HumanInfo;

            foreach (DataRow HumData in query)
            {
                var strArray = new String[] { HumData.Field<string>("M_Name"), 
                    HumData.Field<int>("M_Age").ToString(), HumData.Field<string>("M_Phone") };
                this.lvList.Items.Add(new ListViewItem(strArray));
            }
            Conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("선택한 데이터를 삭제할까요?", "알림", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dlr)
            {
                case DialogResult.Yes:
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    string Sql = "DELETE FROM HumanInfo WHERE M_Name='" + 
                        this.Human_Name + "' AND M_Phone ='" + this.Human_Phone + "'";
                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("정상적으로 데이터가 삭제되었습니다.", "알림", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvList_DataSetRamda_View();
                        Control_Clear();
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 데이터가 삭제되지 않았습니다.", "에러", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void lvList_DataSetRamda_View()
        {
            this.lvList.Items.Clear();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var OleAdapter = new OleDbDataAdapter("SELECT * FROM HumanInfo", Conn);

            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("dsTable");
            OleAdapter.Fill(ds, "dsTable");

            var query = dt.AsEnumerable().
                Select(HumanInfo => new
                {
                    Name = HumanInfo.Field<string>("M_Name"),
                    Age = HumanInfo.Field<int>("M_Age").ToString(),
                    Phone = HumanInfo.Field<string>("M_Phone")
                });

            foreach (var HumData in query)
            {
                var strArray = new String[] { HumData.Name, HumData.Age, HumData.Phone };
                this.lvList.Items.Add(new ListViewItem(strArray));
            }
            Conn.Close();
        }

        private void lvList_Click(object sender, EventArgs e) //선택한 Items의 각 컬럼값을 입력 컨트롤에 대입
        {
            this.txtName.Text = this.lvList.SelectedItems[0].SubItems[0].Text;
            this.txtAge.Text = this.lvList.SelectedItems[0].SubItems[1].Text;
            this.txtCellPhone.Text = this.lvList.SelectedItems[0].SubItems[2].Text;
            Human_Name = this.lvList.SelectedItems[0].SubItems[0].Text;
            Human_Phone = this.lvList.SelectedItems[0].SubItems[2].Text;
        }
    }
}
