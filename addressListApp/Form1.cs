using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
        private string _id = "root";
        private string _pw = "dw#1234";
        private string _database = "employee_list";
        private string _server = "192.168.0.180";
        private string _port = "3306";

        string _connectionAddress = "";

        public List<string> listItem = new List<string>(); // Row를 담을 객체
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체
        public string emp_name = "";

        public Form1()
        {
            InitializeComponent();

            _connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);
            
            // 검색 콤보박스에 데이터 처리
            typeList.Add(new { Display = "이름", Value = "emp_name" });
            typeList.Add(new { Display = "부서", Value = "department" });
            typeList.Add(new { Display = "직급", Value = "rank_position" });
            typeList.Add(new { Display = "주소", Value = "home_address" });
            typeList.Add(new { Display = "이메일", Value = "mail_address" });
            
            cboxCondition.DataSource = typeList;
            cboxCondition.DisplayMember = "Display";
            cboxCondition.ValueMember = "Value";
            
            selectAll();

        }

        public void selectAll()
        {
            // 전체 데이터를 조회합니다.          
            string selectQuery = string.Format("SELECT * FROM employee_list ORDER BY emp_name");

            DataSet ds = CmdMysql.ExecuteDataSet(selectQuery);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

            // DataGridView에 새로운 열 추가
            DataGridViewTextBoxColumn isModifiedColumn = new DataGridViewTextBoxColumn();
            isModifiedColumn.HeaderText = "수정됨";
            isModifiedColumn.Name = "IsModified"; // 데이터 소스와 바인딩할 열의 이름
            isModifiedColumn.DataPropertyName = "IsModified";
            dataGridView1.Columns.Add(isModifiedColumn);

            dataGridView1.ClearSelection();

            // 테이블 모양 조절
            updateColumnHeaderText();
            editColumnIndex();
            editColumnWidth();

            

        }

        private void editColumnWidth()
        {
            // 컬럼 width 조절
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["emp_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["rank_position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["mail_address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["age"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void editColumnIndex()
        {
            dataGridView1.Columns["id"].DisplayIndex = 0;
            dataGridView1.Columns["emp_name"].DisplayIndex = 1;
            dataGridView1.Columns["department"].DisplayIndex = 2;
            dataGridView1.Columns["rank_position"].DisplayIndex = 3;
            dataGridView1.Columns["mail_address"].DisplayIndex = 4;
            dataGridView1.Columns["phone_num"].DisplayIndex = 5;
            dataGridView1.Columns["com_call_num"].DisplayIndex = 6;
            dataGridView1.Columns["home_address"].DisplayIndex = 7;
            dataGridView1.Columns["gender"].DisplayIndex = 8;
            dataGridView1.Columns["age"].DisplayIndex = 9;
            dataGridView1.Columns["join_date"].DisplayIndex = 10;
            dataGridView1.Columns["IsModified"].DisplayIndex = 11;
        }

        // 데이터 소스 바인딩 후 컬럼 헤더 텍스트 변경
        private void updateColumnHeaderText()
        {
            dataGridView1.Columns["emp_name"].HeaderText = "이름";
            dataGridView1.Columns["department"].HeaderText = "부서";
            dataGridView1.Columns["rank_position"].HeaderText = "직책";
            dataGridView1.Columns["mail_address"].HeaderText = "이메일";
            dataGridView1.Columns["phone_num"].HeaderText = "개인번호";
            dataGridView1.Columns["com_call_num"].HeaderText = "회사번호";
            dataGridView1.Columns["gender"].HeaderText = "성별";
            dataGridView1.Columns["age"].HeaderText = "나이";
            dataGridView1.Columns["home_address"].HeaderText = "주소";
            dataGridView1.Columns["join_date"].HeaderText = "입사일";

        }

        public bool IsValidAge(string age) => Regex.IsMatch(age, @"[0-9]"); // 나이 정규식
        public bool IsValidEmail(string email) => Regex.IsMatch(email, 
            @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?"); // 이메일 정규식

        public bool IsValidPhoneNum(string phoneNum) => Regex.IsMatch(phoneNum, @"^01[016789]-\d{3,4}-\d{4}$"); // 폰넘버 정규식 
        public bool IsValidComNum(string comNum) => Regex.IsMatch(comNum, @"^(\d{2,4})?-(\d{3,4})-(\d{4})$"); // 회사번호 정규식 

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            
            using(MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    dataGridView1.DataSource = null; // 기존 dataGridView 정리
                    DataSet ds = new DataSet();
                    string queryStr = string.Format("SELECT * FROM employee_list WHERE {0} LIKE '%{1}%' ORDER BY emp_name;", cboxCondition.SelectedValue, tboxSearch.Text);
                    //Trace.WriteLine("########### 검색쿼리 : " + queryStr);
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(queryStr, conn);
                    adapter.Fill(ds, "employee_list");
                    conn.Close();
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.ClearSelection();

                    // 테이블 모양 관련
                    updateColumnHeaderText();
                    editColumnWidth();
                    editColumnIndex();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                
            }
        }
        

        public void btnInsert_Click(object sender, EventArgs e)
        {

            InsertForm insertForm = new InsertForm(this); // 직원 등록 폼 생성.
            insertForm.ShowDialog(); // newForm.ShowDialog(); // 모달 방식으로 새 폼을 띄우려면 이 코드를 사용하세요.
            
            //selectAll();
            //selectModifiedRow(emp_name); // 수정된 로우 셀렉트
            

        }

        public void selectModifiedRow(string emp_name)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["emp_name"].Value != null && (string)row.Cells["emp_name"].Value == emp_name)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    // 선택된 행이 보이도록 스크롤
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listItem.Count == 11)
            {   
                // 새 폼 인스턴스 생성
                UpdateForm updateForm = new UpdateForm(this);

                // updateForm에 데이터를 listItem으로 담아서 보냄
                updateForm.setItem(listItem);

                // 새 폼 표시
                updateForm.ShowDialog();
            } else { MessageBox.Show("하나의 사원을 선택하세요."); }

            //selectAll();
            //selectModifiedRow(emp_name);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listItem[0] != null)
                {
                    DelForm delForm = new DelForm(this);
                    delForm.setItem(listItem);
                    delForm.ShowDialog();
                }

                listItem.Clear();
            }
            catch
            {
                MessageBox.Show("하나의 사원을 클릭하세요");
            }

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        // gender 컬럼 데이터 남자, 여자로 변경.
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // DataGridView가 데이터 소스와 바인딩된 경우에만 진행
            if (dataGridView1.DataSource != null)
            {
                // 현재 행이 수정된 행이면 배경색 변경
                if (dataGridView1.Rows[e.RowIndex].Cells["IsModified"].Value != null && (bool)dataGridView1.Rows[e.RowIndex].Cells["IsModified"].Value)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // 수정된 행의 텍스트 색상 변경
                }
                else
                {
                    // 수정되지 않은 행은 기본 배경색으로 변경
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }

                // 젠더 컬럼의 값을 1, 2 에서 남자, 여자로
                if (dataGridView1.Columns[e.ColumnIndex].Name == "gender" && e.Value != null)
                {
                    switch (e.Value.ToString())
                    {
                        case "1":
                            {
                                e.Value = "남자";
                                e.FormattingApplied = true;
                            }
                            break;
                        case "2":
                            {
                                e.Value = "여자";
                                e.FormattingApplied = true;
                            }
                            break;
                    }
                }
            }

            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // 이전에 클릭한 사원 정보 클리어
            if(listItem.Count != 0)
            {
                listItem.Clear();
            }
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {   
                row = dataGridView1.SelectedRows[i];

                for (int j = 0; j < row.Cells.Count; j++)
                {   
                    listItem.Add(row.Cells[j].Value.ToString()); // listItem에 SelectedRows의 데이터 (12 * n)개 담아 
                }
            }

        }

        public void deleteData()
        {   
            using(MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                try
                {   
                    string deleteQuery = "DELETE FROM employee_list " +
                                        "WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@id", listItem[0]);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }


        }

        // 종료 버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnUpdate_Click(sender, e);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 컨텍스트 메뉴를 생성하고 표시
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("수정", null, this.btnUpdate_Click);
                contextMenu.Items.Add("삭제", null, this.btnDelete_Click);

                // 메뉴를 마우스 위치에 표시
                var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);
                contextMenu.Show(dataGridView1, relativeMousePosition);
            }
        }

        private void tboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {   
                this.btnSearch_Click(sender, e); 
                e.SuppressKeyPress = true; // 선택한 이벤트가 전파되지 않도록, 엔터 키 이벤트가 다른 동작을 하지 않도록 방지.

            }
        }

        public void getEmpName(string text)
        {
            emp_name = text;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                // 변경된 행의 IsModified 속성을 true로 설정
                dataGridView1.Rows[e.RowIndex].Cells["IsModified"].Value = true;
            }
        }
    }
}
