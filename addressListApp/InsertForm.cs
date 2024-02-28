using Dawool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            cboxGender.DataSource = typeList;
            cboxGender.DisplayMember = "Display";
            cboxGender.ValueMember = "Value";
        }

        private List<string> getCboxItems(string item)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string queryStr = $"SELECT DISTINCT {item} FROM employee_list"; // 쿼리에 Parameters.AddWithValue(); 방식은 컬럼명이나 테이블명에 사용 불가
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                
                MySqlCommand cmd = new MySqlCommand(queryStr, conn);
                adapter.SelectCommand = cmd;

                DataSet ds = new DataSet();
                adapter.Fill(ds, "employee_list");

                List<string> cboxItems = new List<string>();

                foreach (DataRow row in ds.Tables["employee_list"].Rows)
                {
                    cboxItems.Add(row[item].ToString());
                }
                conn.Close();
                return cboxItems;
            }
                
        }
        // 콤보박스 항목 들어가면 드롭다운
        private void comboBoxGender_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }


        private void btnInsertSubmit_Click (object sender, EventArgs e)
        {   
            insertData();
            form1.selectAll();
            form1.selectUpdatedRow(tboxName.Text);
        }

        private void insertData()
        {
            int gender;
            string insertQuery = "INSERT INTO employee_list (" +
                                        "emp_name" +
                                        ", gender" +
                                        ", age" +
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
                                        ", @join);";
            using (MySqlConnection mySqlConn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    mySqlConn.Open();

                    MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConn);
                    cmd.Parameters.AddWithValue("@name", tboxName.Text);
                    if (cboxGender.Text == "남자")
                    {
                        gender = 1;
                    }
                    else
                    {
                        gender = 2;
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", tboxAge.Text);
                    cmd.Parameters.AddWithValue("@address", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@dept", cboxDept.Text);
                    cmd.Parameters.AddWithValue("@rank", cboxRank.Text);
                    cmd.Parameters.AddWithValue("@com", tboxComNum.Text);
                    cmd.Parameters.AddWithValue("@phone", tboxHpNum.Text);
                    cmd.Parameters.AddWithValue("@email", tboxEmail1.Text + "@" + tboxEmail2.Text);
                    cmd.Parameters.AddWithValue("@join",  DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss"));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{tboxName.Text} 사원을 추가하였습니다.");
                    
                    mySqlConn.Close();
                    this.Close();
                }
                catch
                {
                    if (tboxName.Text == "") { MessageBox.Show($"{label_name.Text}를 올바르게 입력하세요"); }
                    else if (cboxGender.Text == "") { MessageBox.Show($"{label_gender.Text}를 올바르게 입력하세요"); }
                    else if (tboxAge.Text == "" || !Form1.IsValidAge(tboxAge.Text)) { MessageBox.Show($"{label_age.Text}를 올바르게 입력하세요"); }
                    //else if (tboxAddress.Text == "") MessageBox.Show($"{label_address.Text}를 올바르게 입력하세요");
                    //else if (cboxDept.Text == "") MessageBox.Show($"{label_dept.Text}를 올바르게 입력하세요");
                    //else if (cboxRank.Text == "") MessageBox.Show($"{label_rank.Text}를 올바르게 입력하세요");
                    //else if (tboxComNum.Text == "") MessageBox.Show($"{label_com_num.Text}를 올바르게 입력하세요");
                    //else if (tboxHpNum.Text == "") MessageBox.Show($"{label_hp.Text}를 올바르게 입력하세요");
                    //else if (tboxEmail1.Text == "" || tboxEmail2.Text == "" || !Form1.IsValidEmail(tboxEmail1.Text + "@" + tboxEmail2.Text)) 
                    //{ 
                    //    Console.WriteLine("이메일 : " + tboxEmail1.Text + "@" + tboxEmail2.Text);
                    //    MessageBox.Show($"{lblEmail1.Text}을 올바르게 입력하세요"); 
                    //}

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>() { "department", "rank_position" }; // 가져올 목록의 컬럼명

            string[] deptListItem = getCboxItems(itemList[0]).ToArray();
            Trace.WriteLine("부서목록 : " + deptListItem);
            string[] rankListItem = getCboxItems(itemList[1]).ToArray();
            cboxDept.Items.AddRange(deptListItem); // 부서 목록을 cbox에 담기
            cboxRank.Items.AddRange(rankListItem); // 직급 목록을 cbox에 담기

            // 널값 제거
            cboxDept.Items.Remove("");
            cboxRank.Items.Remove("");

            tboxEmail2.Enabled = false;
            tboxEmail2.BackColor = Color.LightGray;
        }

        private void label_rank_Click(object sender, EventArgs e)
        {

        }

        private void cboxDept_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }

        // 콤보박스 입장하면 드롭다운
        private void toDroppedDownTrue(object sender)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }

        private void cboxRank_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void cboxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEmail.Text == "직접입력")
            {
                // "직접 입력"이 선택되었을 때 텍스트박스 활성화
                tboxEmail2.Enabled = true;
                tboxEmail2.BackColor = Color.White;
                tboxEmail2.Focus(); // 텍스트박스로 포커스 이동
            }
            else
            {
                tboxEmail2.Enabled = false;
                tboxEmail2.BackColor = Color.LightGray; // tbox 회색으로
                tboxEmail2.Text = cboxEmail.Text;
            }
        }
    }
}
