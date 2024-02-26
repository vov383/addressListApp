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
    public partial class UpdateForm : Form
    {
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체
        string _id = "root";
        string _pw = "dw#1234";
        string _database = "employee_list";
        string _server = "192.168.0.180";
        string _port = "3306";
        string _connectionAddress = "";

        List<string> listItem = new List<string>(); // 메인 폼에서 넘겨준 값 저장하여 update폼에서 사용할 수 있도록 함
        Form1 form1;

        public UpdateForm(Form1 form1)
        {
            _connectionAddress = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _server, _port, _database, _id, _pw);

            InitializeComponent();
            this.form1 = form1;

            typeList.Add(new { Display = "남성", Value = 1 });
            typeList.Add(new { Display = "여성", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";
        }



        private void comboBoxGender_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }

        private void btn_update_submit_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                try
                {
                    int gender;
                    // DB의 gender컬럼에서 0은 여자, 이외는 남자로 변경하여 폼에서 출력
                    if (comboBoxGender.Text == "여자")
                    {
                        gender = 2;
                    }
                    else
                    {
                        gender = 1;
                    }
                    conn.Open();
                    string updateQuery =
                "UPDATE employee_list " +
                "SET emp_name = @name, gender = @gender, age = @age, home_address = @home, department = @dept" +
                    ", rank_position = @rank, com_call_num = @com,  phone_num = @phone, mail_address = @email" +
                "WHERE id = @index;";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", textBoxAge.Text);
                    cmd.Parameters.AddWithValue("@home", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@dept", textBoxDept.Text);
                    cmd.Parameters.AddWithValue("@rank", textBoxPositionRank.Text);
                    cmd.Parameters.AddWithValue("@com", textBoxComNum.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxHpNum.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@index", listItem[0]);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch 
                {

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
    }
}
