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
    public partial class DelForm : Form
    {
        Form1 form1;
        List<string> listItem = new List<string>(); // Form1(메인폼) 데이터를 SetItem에 넣어서 다시 여기 리스트로 add함

        public DelForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }

        public void setItem(List<string> item)
        {
            for (int i = 0; i < item.Count; i++) {
                listItem.Add(item[i]);
            }

        }

        private void btn_DelConfirm_Click(object sender, EventArgs e)
        {
            form1.deleteData();
            form1.selectAll();
            MessageBox.Show($"{listItem[1]} 사원을 삭제하였습니다.");
            this.Close();
            listItem.Clear();
            //form1.selectAll();
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            if (listItem.Count == 11)
            {
                msg_label.Text = $"{listItem[1]} 님의 데이터를 \n정말 삭제하시겠습니까?";
            } else {
                msg_label.Text = $"{listItem.Count / 11}개의 데이터를 \n정말 삭제하시겠습니까?";
            }
        }

        private void btn_DelCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelForm_KeyDown(object sender, KeyEventArgs e)
        {   
            if(e.KeyCode == Keys.Y) 
            {
                btn_DelConfirm_Click(sender, e);
            } else if (e.KeyCode == Keys.N) 
            {
                this.Close();     
            }
        }
    }
}
