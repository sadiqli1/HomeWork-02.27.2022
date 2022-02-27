using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_02._27._2022
{
    public partial class Student  //fillds
    {
        public string GroupNo;
        public string Name;
        public string Surname;
        public int Age;

    }
    public partial class Student  //constructor
    {
        public Student(string name, string surname, string groupno, int age)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Age = age;
        }
    }

    public partial class Student   //Methods
    {
        public void _student(int age)
        {
            var b = CheckFullname(Name, Surname);
            var a = CheckGroupNo(GroupNo);
            bool checkgroupno = a;
            bool checkfullname = b;
            bool _resault = a && b;
            if (_resault == true)
            {
                Console.WriteLine(Name + " " + Surname + " " + age + " " + GroupNo);
            }
            else
            {
                Console.WriteLine("melumati duzgun daxil edin");
            }
        }

        public static bool CheckGroupNo(string groupno)
        {
            bool hasupper = false;
            bool hasdigit = false;
            if (groupno.Length == 4)
            {
                for (int i = 0; i < groupno.Length; i++)
                {
                    if (char.IsUpper(groupno[0]) && char.IsDigit(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]))
                    {
                        hasupper = true;
                        hasdigit = true;
                    }
                }
                bool resault = hasdigit && hasupper;
                return resault;
            }
            return false;
        }
        public static bool CheckFullname(string name, string surname)
        {
            bool hasupper = false;
            bool hasupper1 = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[0]))
                {
                    hasupper = true;
                }
            }
            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsUpper(surname[0]))
                {
                    hasupper1 = true;
                }
            }
            bool resault = hasupper && hasupper1;
            return resault;

        }
    }
}
