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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        public winFormApp()
        {
            InitializeComponent();

            _connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);

            typeList.Add(new { Display = "남성", Value = 1 });
            typeList.Add(new { Display = "여성", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";

            selectAll();

        }
        

        private void selectAll()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    conn.Open();

                    // 전체 데이터를 조회합니다.          
                    string selectQuery = string.Format("SELECT * FROM employee_list");

                    MySqlCommand command = new MySqlCommand(selectQuery, conn);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewAddr.Items.Clear(); //listview 지우기

                    while (table.Read())
                    {   
                        ListViewItem item = new ListViewItem();
                        
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["emp_name"].ToString());
                        item.SubItems.Add(table["gender"].ToString());
                        if (table["gender"].ToString() == "1")
                        {
                            item.SubItems[2].Text = "남성";
                        } else {
                            item.SubItems[2].Text = "여성";
                        }
                        item.SubItems.Add(table["age"].ToString());
                        item.SubItems.Add(table["home_address"].ToString());
                        item.SubItems.Add(table["department"].ToString());
                        item.SubItems.Add(table["rank_position"].ToString());
                        item.SubItems.Add(table["com_call_num"].ToString());
                        item.SubItems.Add(table["phone_num"].ToString());
                        item.SubItems.Add(table["mail_address"].ToString());
                        item.SubItems.Add(table["join_date"].ToString());

                        listViewAddr.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        } //sellectAll() end

        private void textBoxClear()
        {
            textBoxName.Text = "";
            comboBoxGender.Text = "";
            textBoxAge.Text = "";
            textBoxAddress.Text = "";
            textBoxDept.Text = "";
            textBoxPositionRank.Text = "";
            textBoxComNum.Text = "";
            textBoxHpNum.Text = "";
            textBoxEmail.Text = "";
        }

        private void winFormApp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void listViewAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;

            int index = listView.FocusedItem.Index;
            textBoxName.Text = listViewAddr.Items[index].SubItems[1].Text;
            comboBoxGender.Text = listViewAddr.Items[index].SubItems[2].Text;
            textBoxAge.Text = listViewAddr.Items[index].SubItems[3].Text;
            textBoxAddress.Text = listViewAddr.Items[index].SubItems[4].Text;
            textBoxDept.Text = listViewAddr.Items[index].SubItems[6].Text;
            textBoxPositionRank.Text = listViewAddr.Items[index].SubItems[7].Text;
            textBoxHpNum.Text = listViewAddr.Items[index].SubItems[8].Text;
            textBoxComNum.Text = listViewAddr.Items[index].SubItems[9].Text;
            textBoxEmail.Text = listViewAddr.Items[index].SubItems[10].Text;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    conn.Open();
                    string insertQuery = string.Format("INSERT INTO employee_list (" +
                        "emp_name, gender, age, home_address, department, rank_position, " +
                        "com_call_num, phone_num, mail_address, join_date) " +
                        "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', NOW());", 
                        textBoxName.Text, comboBoxGender.SelectedValue, textBoxAge.Text, textBoxAddress.Text, textBoxDept.Text,
                        textBoxPositionRank.Text, textBoxHpNum.Text, textBoxComNum.Text, textBoxEmail.Text);
                    
                    MySqlCommand command = new MySqlCommand(insertQuery, conn);

                    if(command.ExecuteNonQuery() != 1) {
                        MessageBox.Show("Fail to insert Data");
                    }
                    textBoxClear();

                    selectAll();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    conn.Open();

                    int pos = listViewAddr.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);

                    string updateQuery = string.Format("UPDATE employee_list SET emp_name = '{0}', gender = '{1}', age = '{2}', home_address = '{3}', department = '{4}', rank_position = '{5}', com_call_num = '{6}',  phone_num = '{7}', mail_address = '{8}' WHERE id = '{9}';", textBoxName.Text, comboBoxGender.SelectedValue, textBoxAge.Text, textBoxAddress.Text, textBoxDept.Text, textBoxPositionRank.Text, textBoxComNum.Text, textBoxHpNum.Text, textBoxEmail.Text, index);
                    MySqlCommand command = new MySqlCommand(updateQuery, conn);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update data.");
                    }
                    textBoxClear();

                    selectAll();
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        

        private void btnDelClick(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    conn.Open();

                    int pos = listViewAddr.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);
                        

                    string delQuery = string.Format("DELETE FROM employee_list WHERE id = {0};", index);

                    MySqlCommand command = new MySqlCommand(delQuery, conn);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Fail to Delete Data");
                    }
                    textBoxClear();

                    selectAll();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void comboBoxGender_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }
    }
}
