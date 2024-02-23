using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressListApp
{
    internal class Employee

    {
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public DateTime JoinDate { get; set; }
        public string Department { get; set; }
        public string RankPosition { get; set; }
        public string ComCallNum { get; set; }
        public string PhoneNum { get; set; }
        public string MailAddress { get; set; }

        // 기본 생성자
        public Employee() { }

        // 모든 속성을 초기화하는 생성자
        public Employee(string empName, string gender, int age, string homeAddress,
                        DateTime joinDate, string department, string rankPosition,
                        string comCallNum, string phoneNum, string mailAddress)
        {
            EmpName = empName;
            Gender = gender;
            Age = age;
            HomeAddress = homeAddress;
            JoinDate = joinDate;
            Department = department;
            RankPosition = rankPosition;
            ComCallNum = comCallNum;
            PhoneNum = phoneNum;
            MailAddress = mailAddress;
        }
    }
}