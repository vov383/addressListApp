using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class winFormApp : Form
    {
        //string _id = "root";
        //string _pw = "dw#1234";
        //string _database = "employee_list";
        //string _server = "192.168.0.180";
        //string _connectionAddress = "";
        //string _port = "3306";
        
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        public winFormApp()
        {
            InitializeComponent();

            //_connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);

            typeList.Add(new { Display = "남성", Value = 1 });
            typeList.Add(new { Display = "여성", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";

            selectAll();

        }

        private void selectAll()
        {
            // 전체 데이터를 조회합니다.          
            string selectQuery = string.Format("SELECT * FROM employee_list");
            DataSet ds = CommMysql.ExecuteDataSet(selectQuery);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString()); // 첫 번째 열을 ListViewItem으로 생성
                    item.SubItems.Add(row["emp_name"].ToString());
                    item.SubItems.Add(row["gender"].ToString());
                    item.SubItems.Add(row["age"].ToString());
                    item.SubItems.Add(row["home_address"].ToString());
                    item.SubItems.Add(row["department"].ToString());
                    item.SubItems.Add(row["rank_position"].ToString());
                    item.SubItems.Add(row["com_call_num"].ToString());
                    item.SubItems.Add(row["phone_num"].ToString());
                    item.SubItems.Add(row["join_date"].ToString());

                    listViewAddr.Items.Add(item); // 생성된 ListViewItem을 ListView에 추가
                }
            }
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
            textBoxDept.Text = listViewAddr.Items[index].SubItems[5].Text;
            textBoxPositionRank.Text = listViewAddr.Items[index].SubItems[6].Text;
            textBoxHpNum.Text = listViewAddr.Items[index].SubItems[7].Text;
            textBoxComNum.Text = listViewAddr.Items[index].SubItems[8].Text;
            textBoxEmail.Text = listViewAddr.Items[index].SubItems[9].Text;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form_add_emp newForm = new Form_add_emp(); // 직원 등록 폼 생성.
            newForm.Show(); // 모달이 아닌 방식으로 새 폼을 띄웁니다.
                            // newForm.ShowDialog(); // 모달 방식으로 새 폼을 띄우려면 이 코드를 사용하세요.




        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int pos = listViewAddr.SelectedItems[0].Index;
            int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);

            string updateQuery = string.Format(
                "UPDATE employee_list " +
                "SET emp_name = '{0}', gender = '{1}', age = '{2}', home_address = '{3}', department = '{4}'" +
                    ", rank_position = '{5}', com_call_num = '{6}',  phone_num = '{7}', mail_address = '{8}' " +
                "WHERE id = '{9}';"
                , textBoxName.Text, comboBoxGender.SelectedValue, textBoxAge.Text, textBoxAddress.Text
                , textBoxDept.Text, textBoxPositionRank.Text, textBoxComNum.Text, textBoxHpNum.Text, textBoxEmail.Text
                , index);

            CommMysql.ExecuteNonQuery(updateQuery);

            //Age 입력검증
            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("나이 항목에 숫자를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void btnDelClick(object sender, EventArgs e)
        {   
            int pos = listViewAddr.SelectedItems[0].Index;
            int index = Convert.ToInt32(listViewAddr.Items[pos].SubItems[0].Text);
            string delQuery = string.Format("DELETE FROM employee_list WHERE id = {0};", index);
            CommMysql.ExecuteNonQuery(delQuery);
            
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
