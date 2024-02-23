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
    public partial class form_insert : Form
    {
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체
        //private int index;

        public form_insert()
        {
            InitializeComponent();

            typeList.Add(new { Display = "남성", Value = 1 });
            typeList.Add(new { Display = "여성", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";
        }

        public form_insert(int index)
        {
            //this.index = index
            string updateQuery = 
                "UPDATE employee_list " +
                "SET emp_name = @name, gender = @gender, age = @age, home_address = @home, department = @dept" +
                    ", rank_position = @rank, com_call_num = @com,  phone_num = @phone, mail_address = @email" +
                "WHERE id = @index;";

            CommMysql.ExecuteNonQuery(updateQuery);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 'age' 필드의 입력 값을 검증합니다.
            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("나이 항목에 숫자를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 메서드를 더 이상 진행하지 않고 종료합니다.
            }

            string insertQuery = "INSERT INTO employee_list (" +
                            "emp_name, gender, age, home_address, department, rank_position" +
                            ", com_call_num, phone_num, mail_address, join_date) " +
                        "VALUES (" +
                            "@name, @gender, @age, @home, @dept, @rank, @com, @phone, @email, NOW());";
                        
            int result = CommMysql.ExecuteNonQuery(insertQuery);

            if (result > 0)
            {
                MessageBox.Show("데이터가 성공적으로 삽입되었습니다.");
            }
            else
            {
                MessageBox.Show("데이터 삽입에 실패했습니다.");
            }

            
        }

        private void textBoxHpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                comboBox.DroppedDown = true;
            }
        }
    }
}
