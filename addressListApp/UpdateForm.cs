﻿using Dawool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressListApp
{
    public partial class UpdateForm : Form
    {
        string _connectionAddress = "";
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        List<string> listItem = new List<string>(); // 메인 폼에서 넘겨준 값 저장하여 update폼에서 사용할 수 있도록 함
        Form1 form1;
        string empId = "";

        public UpdateForm(Form1 form1)
        {
            _connectionAddress = string.Format("server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.180", "employee_list", "root", "dw#1234");

            InitializeComponent();
            this.form1 = form1;

            typeList.Add(new { Display = "남자", Value = 1 });
            typeList.Add(new { Display = "여자", Value = 2 });

            cboxGender.DataSource = typeList;
            cboxGender.DisplayMember = "Display";
            cboxGender.ValueMember = "Value";
        }


        private void cboxGender_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }
        private void cboxDept_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }

        private void cboxRank_Enter(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }

        // 콤보박스 입장하면 드롭다운
        private static void toDroppedDownTrue(object sender)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }

        private void btn_update_submit_Click(object sender, EventArgs e)
        {   
            // 입력검증 자리 
            validateAndProceed();
            //form1.selectAll();
            //form1.selectUpdatedRow(tboxName.Text); // 수정한 사원 선택 
            listItem.Clear();
            

        }

        private void validateAndProceed()
        {
            form1 = new Form1();
            // 입력검증
            if (string.IsNullOrEmpty(tboxName.Text))
            {
                MessageBox.Show($"{label_name.Text}를 올바르게 입력하세요");
                tboxName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tboxAge.Text) || !form1.IsValidAge(tboxAge.Text))
            {
                MessageBox.Show($"{label_age.Text}를 올바르게 입력하세요");
                tboxAge.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tboxAddress.Text))
            {
                MessageBox.Show($"{label_address.Text}를 올바르게 입력하세요");
                tboxAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxDept.Text))
            {
                MessageBox.Show($"{label_dept.Text}를 올바르게 입력하세요");
                cboxDept.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxRank.Text))
            {
                MessageBox.Show($"{label_rank.Text}를 올바르게 입력하세요");
                cboxRank.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tboxComNum.Text) || !form1.IsValidComNum(tboxComNum.Text))
            {
                MessageBox.Show($"{label_com_num.Text}를 올바르게 입력하세요");
                tboxComNum.Focus();
                return;
            }
            if (tboxHpNum.Text == "" || !form1.IsValidPhoneNum(tboxHpNum.Text))
            {
                MessageBox.Show($"{label_hp.Text}를 올바르게 입력하세요");
                tboxHpNum.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tboxEmail1.Text) || string.IsNullOrEmpty(cboxEmail.Text) || !form1.IsValidEmail(tboxEmail1.Text + "@" + tboxEmail2.Text))
            {
                MessageBox.Show($"{lblEmail1.Text}을 올바르게 입력하세요");
                tboxEmail1.Focus();
                return;
            }
            updateData(); // 수정 실행
        }

        private void updateData()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE employee_list " +
                                        "SET emp_name = @name" +
                                            ", gender = @gender" +
                                            ", age = @age" +
                                            ", home_address = @home" +
                                            ", department = @dept" +
                                            ", rank_position = @rank" +
                                            ", com_call_num = @com" +
                                            ", phone_num = @phone" +
                                            ", mail_address = @email " +
                                        "WHERE id = @index;";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@name", tboxName.Text);
                    
                    // DB의 gender컬럼에서 2은 여자, 이외는 남자로 변경하여 폼에서 출력
                    int gender;
                    if (cboxGender.Text == "여자") { gender = 2; }
                    else { gender = 1; }
                    cmd.Parameters.AddWithValue("@gender", gender);

                    cmd.Parameters.AddWithValue("@age", tboxAge.Text);
                    cmd.Parameters.AddWithValue("@home", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@dept", cboxDept.Text);
                    cmd.Parameters.AddWithValue("@rank", cboxRank.Text);
                    cmd.Parameters.AddWithValue("@com", tboxComNum.Text);
                    cmd.Parameters.AddWithValue("@phone", tboxHpNum.Text);
                    cmd.Parameters.AddWithValue("@email", tboxEmail1.Text + "@" + tboxEmail2.Text);
                    cmd.Parameters.AddWithValue("@index", empId);
                    
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    
                    MessageBox.Show($"{tboxName.Text} 사원을 수정하였습니다.");
                    form1.getEmpId(empId);
                    this.Close();
                    //form1.selectUpdatedRow(tboxName.Text);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setItem(List<string> item)
        {
            for (int i = 0; i < item.Count; i++)
            {
                listItem.Add(item[i]); // 메인폼에서 데이터를 받아 listItem변수에 입력
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {   
            // 부서, 직급 콤보박스에 항목 생성
            List<string> itemList = new List<string>() { "department", "rank_position" }; // 가져올 목록의 컬럼명

            string[] deptListItem = getCboxItems(itemList[0]).ToArray();
            string[] rankListItem = getCboxItems(itemList[1]).ToArray();
            cboxDept.Items.AddRange(deptListItem); // 부서 목록을 cbox에 담기
            cboxRank.Items.AddRange(rankListItem); // 직급 목록을 cbox에 담기

            // 널값 제거
            cboxDept.Items.Remove("");
            cboxRank.Items.Remove("");

            // 젠더 콤보박스에 1,2 를 남자, 여자로
            try
            {
                // id를 제외하고 텍스트박스 및 콤보박스에 정보 등록
                empId = listItem[0]; // 직원 id
                tboxName.Text = listItem[1];
                int gender = 0;
                if(listItem[2] == "2")
                {
                    cboxGender.Text = "여자";
                } else
                {
                    cboxGender.Text = "남자";
                }
                tboxAge.Text = listItem[3];
                tboxAddress.Text = listItem[4];
                cboxDept.Text = listItem[6];
                cboxRank.Text = listItem[7];
                tboxComNum.Text = listItem[8];
                tboxHpNum.Text = listItem[9];
                
                string[] mailParts = listItem[10].Split('@'); // 메일 앞 부분, 뒷 부분 Splite()
                tboxEmail1.Text = mailParts[0];
                tboxEmail2.Text = mailParts[1];
                tboxEmail2.Enabled = false;
                tboxEmail2.BackColor = Color.LightGray;
                cboxEmail.Text = mailParts[1];
                
            }
            catch
            {
                MessageBox.Show("데이터 선택이 되지 않았습니다.");
            }
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

        private void cboxGender_Enter_1(object sender, EventArgs e)
        {
            toDroppedDownTrue(sender);
        }
    }
}
