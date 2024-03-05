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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace addressListApp
{
    public partial class Form1 : Form
    {
        string _connectionAddress = string.Format("server={0};Database={1};Uid={2};Pwd={3};", "192.168.0.180", "employee_list", "root", "dw#1234");

        public List<string> listItem = new List<string>();
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        string empId = "";
        string empName = "";

        public Form1()
        {
            InitializeComponent();



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
            dataGridView1.ClearSelection();

            // 테이블 모양 조절
            updateColumnHeaderText();
            editColumnIndex();
            editColumnWidth();

            //// DataGridView에 새로운 열 추가
            //DataGridViewCheckBoxColumn isModifiedColumn = new DataGridViewCheckBoxColumn();
            //isModifiedColumn.HeaderText = "Is Modified";
            //isModifiedColumn.Name = "IsModified"; // 데이터 소스와 바인딩할 열의 이름
            //isModifiedColumn.DataPropertyName = "IsModified";
            //dataGridView1.Columns.Add(isModifiedColumn);


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

        public void getEmpId(string empId)
        {
            this.empId = empId;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
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

            listItem.Clear();
            selectAll();


        }
        public int getMaxId()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    conn.Open();
                    string queryStr = "SELECT MAX(id) FROM empolyee_list;";

                    MySqlCommand cmd = new MySqlCommand(queryStr, conn);
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    throw;
                }

            }
        }
        public void selectUpdatedRow(string empId)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells["id"].Value == empId)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
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

            listItem.Clear();
            selectAll();
            empId = getMaxId().ToString();
            selectUpdatedRow(empId);


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
                selectAll();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // 이전에 클릭한 사원 정보 클리어
            if (listItem.Count != 0)
            {
                listItem.Clear();
            }
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                row = dataGridView1.SelectedRows[i];

                for (int j = 0; j < row.Cells.Count; j++)
                {
                    listItem.Add(row.Cells[j].Value.ToString()); // listItem에 SelectedRows의 데이터 (11 * n)개 담아 
                }
            }

        }

        public void deleteData()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
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
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
                e.SuppressKeyPress = true; // 선택한 이벤트가 전파되지 않도록, 엔터 키 이벤트가 다른 동작을 하지 않도록 방지.

            }
        }

        public void CreateExcelInstance()
        {
            // 엑셀 애플리케이션 인스턴스 생성
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                Console.WriteLine("엑셀이 설치되어 있지 않습니다.");
                return;
            }

            // 새 워크북 생성
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet.Name = "내 데이터";

            // 엑셀 파일 보이기
            excelApp.Visible = true;

        }

        private void btnExportAllTable(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        // 테이블을 엑셀로 저장
        private void ExportToExcel()
        {
            bool IsExport = false;

            // 엑셀 오브젝트 생성
            try
            {
                Excel._Application excel = new Excel.Application();
                Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;

                // DataGridView에 불러온 Data가 아무것도 없을 경우
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("데이터가 없다.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // worksheet = workbook.ActiveSheet;
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                // table 헤더
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[col].HeaderText;
                    }
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;

                // table 나머지
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[row].Cells[col].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveFileDialog = GetExcelSaveDir();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Export 성공");
                    IsExport = true;
                }

                if (IsExport)
                {
                    workbook.Close();
                    excel.Quit();
                    workbook = null;
                    excel = null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("엑셀이 설치되지 않았습니다. 저장할 수 없습니다. -{0}", exc.Message);
            }

        }

        // 사용자로부터 엑셀 파일을 저장할 위치를 선택하는 기능을 담당하는 메서드
        private SaveFileDialog GetExcelSaveDir()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 파일 (*.xlsx)|*.xlsx|모든파일 (*.*)|*.*";
            saveFileDialog.Title = "저장할 위치를 선택하세요";
            saveFileDialog.RestoreDirectory = true; // 마지막에 선택한 디렉토리를 기억합니다.

            return saveFileDialog;
        }

        private void btnOpenExcel(object sender, EventArgs e)
        {
            CreateExcelInstance();
        }

        private void btnExportRow(object sender, EventArgs e)
        {
            bool IsExport = false;

            // 엑셀 오브젝트 생성
            try
            {
                Excel._Application excel = new Excel.Application();
                Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;

                // 데이터가 선택되지 않았다면
                if(dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("선택된 데이터 없어요", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                int cellRowIndex = 0;
                int cellColumnIndex = 0;

                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {

                }

            } catch (Exception exc) 
            {
                MessageBox.Show("오류 - {0}", exc.Message);
            }

        }
    }
}
