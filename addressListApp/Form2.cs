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
    public partial class Form_add_emp : Form
    {
        private BindingList<object> typeList = new BindingList<object>(); // 콤보박스 키벨류 담을 객체

        public Form_add_emp()
        {
            InitializeComponent();

            typeList.Add(new { Display = "남성", Value = 1 });
            typeList.Add(new { Display = "여성", Value = 2 });

            comboBoxGender.DataSource = typeList;
            comboBoxGender.DisplayMember = "Display";
            comboBoxGender.ValueMember = "Value";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 'age' 필드의 입력 값을 검증합니다.
            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Age must be an integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 메서드를 더 이상 진행하지 않고 종료합니다.
            }

            string insertQuery = string.Format(
                        "INSERT INTO employee_list (" +
                            "emp_name, gender, age, home_address, department, rank_position" +
                            ", com_call_num, phone_num, mail_address, join_date) " +
                        "VALUES (" +
                            "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', NOW());",
                        textBoxName.Text, comboBoxGender.SelectedValue, textBoxAge.Text, textBoxAddress.Text, textBoxDept.Text
                        , textBoxPositionRank.Text, textBoxHpNum.Text, textBoxComNum.Text, textBoxEmail.Text);

            int result = CommMysql.ExecuteNonQuery(insertQuery);

            if (result > 0)
            {
                MessageBox.Show("데이터가 성공적으로 삽입되었습니다.");
            }
            else
            {
                MessageBox.Show("데이터 삽입에 실패했습니다.");
            }

            //try
            //{
            //    using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            //    {
            //        conn.Open();



            //        MySqlCommand command = new MySqlCommand(insertQuery, conn);

            //        if (command.ExecuteNonQuery() != 1)
            //        {
            //            MessageBox.Show("Fail to insert Data");
            //        }
            //        textBoxClear();

            //        selectAll();
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }

        private void textBoxHpNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
