using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressListApp
{
    public class Employee

    {
        private string emp_name { get; set; }
        private string gender { get; set; }
        private int age { get; set; }
        private string home_address { get; set; }
        private string join_date { get; set; }
        private string department { get; set; }
        private string rank_position { get; set; }
        private string com_call_num { get; set; }
        private string phone_num { get; set; }
        private string mail_address { get; set; }

        // 기본 생성자
        public Employee() { }

        // 모든 속성을 초기화하는 생성자
        public Employee(string emp_name, string gender, int age, string home_address,
                        string join_date, string department, string rank_position,
                        string com_call_num, string phone_num, string mail_address)
        {
            this.emp_name = emp_name;
            this.gender = gender;
            this.age = age;
            this.home_address = home_address;
            this.join_date = join_date;
            this.department = department;
            this.rank_position = rank_position;
            this.com_call_num = com_call_num;
            this.phone_num = phone_num;
            this.mail_address = mail_address;
        }

    }

}