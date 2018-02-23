using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        /// <summary>
        /// 无参数的构造方法
        /// </summary>
        public Student()
        { }

        //学生ID
        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }


        //学生姓名
        private string studentName;
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        //学生年龄
        private int age =0;
        public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}
        {
            get { return age; }
            set {
                if (age < 18)
                    age = 18;
                else
                    age = value;
            }
        }
    }
}
