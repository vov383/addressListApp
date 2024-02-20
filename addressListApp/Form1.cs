using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace addressListApp
{
    public partial class winFormApp : Form
    {
        string _id = "root";
        string _pw = "dw#1234";
        string _database = "employee_list";
        string _server = "192.168.0.180";
        string _connectionAddress = "";
        string _port = "3306";

        public winFormApp()
        {
            InitializeComponent();

            _connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw, _database);

            selectAll();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectAll();
        }

        private void selectAll()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    // 전체 데이터를 조회합니다.          
                    string selectQuery = string.Format("SELECT * FROM employee_list");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listView1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["emp_name"].ToString());
                        listView1.Items.Add(item);


                    }

                    table.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void winFormApp_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
