﻿using System;
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
        string _id = "root";
        string _pw = "dw#1234";
        string _database = "employee_list";
        string _server = "192.168.0.180";
        string _port = "3306";

        string _connectionAddress = "";

        public List<string> listItem = new List<string>();

        public Form1()
        {
            InitializeComponent();

            _connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);

            selectAll();

        }

        public void selectAll()
        {
            
            // 전체 데이터를 조회합니다.          
            string selectQuery = string.Format("SELECT * FROM employee_list");

            DataSet ds = CmdMysql.ExecuteDataSet(selectQuery);
            DataTable dt = ds.Tables[0]; 
            dataGridView1.DataSource = dt;

            updateColumnHeaderText();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 


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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            selectAll();
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {

            InsertForm insertForm = new InsertForm(this); // 직원 등록 폼 생성.
            insertForm.ShowDialog(); // newForm.ShowDialog(); // 모달 방식으로 새 폼을 띄우려면 이 코드를 사용하세요.
            
            listItem.Clear();

        }

        public void selectUpdatedRow(string emp_name)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) 
            {
                if ((string)row.Cells["emp_name"].Value == emp_name)
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
            if (listItem.Count > 0)
            {   

                // 새 폼 인스턴스 생성
                UpdateForm updateForm = new UpdateForm(this);

                // Employee 객체 생성
                // Employee 객체를 생성하고, DataGridView의 데이터로 속성을 설정합니다.
                updateForm.setItem(listItem);

                // 새 폼 표시
                updateForm.ShowDialog();
            } else
            {
                MessageBox.Show("사원을 선택하세요.");
            }

            listItem.Clear();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listItem[0] != null)
                {
                    DelForm delForm = new DelForm(this);
                    delForm.SetItem(listItem);
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
                    listItem.Add(row.Cells[j].Value.ToString()); // listItem에 SelectedRows의 데이터 (11 * n)개 담아 
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

    }
}
