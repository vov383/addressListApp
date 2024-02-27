using Dawool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressListApp
{
    public partial class InsertForm : Form
    {
        string _id = "root";
        string _pw = "dw#1234";
        string _database = "employee_list";
        string _server = "192.168.0.180";
        string _port = "3306";
        
        string _connectionAddress = "";

        Form1 form1;
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        public InsertForm(Form1 form1)
        {
            this.MaximizeBox = false; // 폼 최대화 기능 off
            InitializeComponent();
            this.form1 = form1;
            _connectionAddress = string.Format("server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.180", "employee_list", "root", "dw#1234");

            typeList.Add(new { Display = "남자", Value = 1 });
            typeList.Add(new { Display = "여자", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";
        }

        private List<string> cBoxList(string item)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string queryStr = "SELECT DISTINCT @item FROM employee_list";
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(queryStr, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "employee_list");

                List<string> strings = new List<string>();


            }
                return null;
        }

        private void comboBoxGender_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }


        private void btnInsertSubmit_Click (object sender, EventArgs e)
        {   
            insertData();
            form1.selectAll();
            form1.selectUpdatedRow(textBoxName.Text);
        }

        private void insertData()
        {
            int gender;
            string insertQuery = "INSERT INTO employee_list (" +
                                        "emp_name, gender, age" +
                                        ", home_address" +
                                        ", department" +
                                        ", rank_position" +
                                        ", com_call_num" +
                                        ", phone_num" +
                                        ", mail_address" +
                                        ", join_date) " +
                                "VALUES (" +
                                        "@name" +
                                        ", @gender" +
                                        ", @age" +
                                        ", @address" +
                                        ", @dept" +
                                        ", @rank" +
                                        ", @com" +
                                        ", @phone" +
                                        ", @email" +
                                        ", NOW());";
            using (MySqlConnection mySqlConn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    mySqlConn.Open();

                    MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConn);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    if (comboBoxGender.Text == "남자")
                    {
                        gender = 1;
                    }
                    else
                    {
                        gender = 2;
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", textBoxAge.Text);
                    cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@dept", textBoxDept.Text);
                    cmd.Parameters.AddWithValue("@rank", textBoxPositionRank.Text);
                    cmd.Parameters.AddWithValue("@com", textBoxComNum.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxHpNum.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{textBoxName.Text} 사원을 추가하였습니다.");

                    mySqlConn.Close();
                    this.Close();
                }
                catch
                {
                    if (textBoxName.Text == "") MessageBox.Show($"{label_name.Text}를 올바르게 입력하세요");
                    else if (comboBoxGender.Text == "") MessageBox.Show($"{label_gender.Text}를 올바르게 입력하세요");
                    else if (textBoxAge.Text == "") MessageBox.Show($"{label_age.Text}를 올바르게 입력하세요");
                    //else if (textBoxAddress.Text == "") MessageBox.Show($"{label_address.Text}를 올바르게 입력하세요");
                    //else if (textBoxDept.Text == "") MessageBox.Show($"{label_dept.Text}를 올바르게 입력하세요");
                    //else if (textBoxPositionRank.Text == "") MessageBox.Show($"{label_rank.Text}를 올바르게 입력하세요");
                    //else if (textBoxComNum.Text == "") MessageBox.Show($"{label_com_num.Text}를 올바르게 입력하세요");
                    //else if (textBoxHpNum.Text == "") MessageBox.Show($"{label_hp.Text}를 올바르게 입력하세요");
                    //else if (textBoxEmail.Text == "") MessageBox.Show($"{label_email.Text}를 올바르게 입력하세요");

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>() { "deptList", "rankList" };

            string[] deptListItem = itemList[0].ToArray();
        }
    }
}
