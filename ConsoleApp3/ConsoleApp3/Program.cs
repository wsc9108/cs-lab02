using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student objStudent = new Student();
            objStudent.Age = 2;

            Console.WriteLine("my age is {0}", objStudent.Age);
            Console.ReadLine();
        }

    }
}
