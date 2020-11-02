using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Student
    {
        internal static string collegename;
        string name;
        string dept;
        internal Student(string name,string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        internal void Displaydetails()
        {
            Console.WriteLine("name is {0}|| dept name is {1}|| coolegename is {2}", name, dept, collegename);

        }

            
    }
    class StaticEg
    {
        static void Main()
        {
            Console.WriteLine("enter collegename");
            Student.collegename = Console.ReadLine();
            string name, dept;
            Console.WriteLine("enter the no of students");
            int no = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[no];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("enter the name and dept");
                name = Console.ReadLine();
                dept = Console.ReadLine();
                student[i] = new Student(name, dept);
            }
            for (int i = 0; i < student.Length; i++)
            {
                student[i].Displaydetails();
            }
            Console.Read();
        }
    }
}
