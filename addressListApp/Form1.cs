using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dawool;
using MySql.Data.MySqlClient;

using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace addressListApp
{
    public partial class Form1 : Form
    {
        //string _id = "root";
        //string _pw = "dw#1234";
        //string _database = "employee_list";
        //string _server = "192.168.0.180";
        //string _connectionAddress = "";
        //string _port = "3306";
        

        public Form1()
        {
            InitializeComponent();

            //_connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);

            selectAll();

        }

        private void selectAll()
        {

            // 전체 데이터를 조회합니다.          
            string selectQuery = string.Format("SELECT * FROM employee_list");
            string gender = "";

            DataSet ds = CommMysql.ExecuteDataSet(selectQuery);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

            updateColumnHeaderText();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        // 데이터 소스 바인딩 후 컬럼 헤더 텍스트 변경
        private void updateColumnHeaderText()
        {
            dataGridView1.Columns["emp_name"].HeaderText = "이름";
            dataGridView1.Columns["gender"].HeaderText = "성별";
            dataGridView1.Columns["age"].HeaderText = "나이";
            dataGridView1.Columns["home_address"].HeaderText = "주소";
            dataGridView1.Columns["department"].HeaderText = "부서";
            dataGridView1.Columns["rank_position"].HeaderText = "직책";
            dataGridView1.Columns["com_call_num"].HeaderText = "회사번호";
            dataGridView1.Columns["phone_num"].HeaderText = "개인번호";
            dataGridView1.Columns["mail_address"].HeaderText = "이메일";
            dataGridView1.Columns["join_date"].HeaderText = "입사일";

        }

        private void winFormApp_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            selectAll();
        }


        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_insert newForm = new form_insert(); // 직원 등록 폼 생성.
            newForm.ShowDialog(); // newForm.ShowDialog(); // 모달 방식으로 새 폼을 띄우려면 이 코드를 사용하세요.
            
            selectAll();


        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            //int pos = listViewAddr.SelectedItems[0].Index;
            //int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);

            form_insert newForm = new form_insert(); // 직원 등록 폼 생성.
            newForm.Show(); // 모달이 아닌 방식으로 새 폼을 띄웁니다.

            selectAll();



            ////Age 입력검증
            //if (!int.TryParse(textBoxAge.Text, out int age))
            //{
            //    MessageBox.Show("나이 항목에 숫자를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

        }


        private void btnDelClick(object sender, EventArgs e)
        {   
            //int pos = listViewAddr.SelectedItems[0].Index;
            //int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);
            //string delQuery = string.Format("DELETE FROM employee_list WHERE id = {0};", index);
            //CommMysql.ExecuteNonQuery(delQuery);
            selectAll();
        }


        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "gender" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "1":
                        e.Value = "남자";
                        e.FormattingApplied = true;
                        break;
                    case "2":
                        e.Value = "여자";
                        e.FormattingApplied = true;
                        break;
                }
            }
        }
    }
}
