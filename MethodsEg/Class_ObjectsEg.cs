using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Class_ObjectsEg
    {
        string Name;
        int age;
        string degree;
        void DisplayDetails()
        {
            Console.WriteLine("name : {0}||age :{1}|| degree : {2}", Name, age, degree);

        }
        static void Main()
        {
            Class_ObjectsEg employee1 = new Class_ObjectsEg();
            employee1.Name = "mani";
            employee1.age = 23;
            employee1.degree = "btech";
            employee1.DisplayDetails();
            Class_ObjectsEg employee2 = new Class_ObjectsEg();
            employee2.Name = "swaroop";
            employee2.age = 18;
            employee2.degree = "inter";
            employee2.DisplayDetails();
            Console.Read();

        }

    }
}
