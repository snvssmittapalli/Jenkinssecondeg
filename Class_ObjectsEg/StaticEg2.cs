using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Mobile
    {
        internal static string companyname;//class variable
        internal string Modelname;//object variable
        //non static method can access both static and non static information
        void Displaymodel()
        {
            Console.WriteLine("companyname {0}||modelname{1}", companyname, Modelname);
        }
        //static method can access only static information
        internal static void Getdata()
        {
            int isbn = 890;
            Console.WriteLine("companyname {0}||modelname{1}", companyname /*Modelname*/);



        }
    }


    class StaticEg2
    {
        float f = 34.90f;
        internal static void Info()
        {
            Console.WriteLine("static method");

        }
        static void Main()
        {
            Mobile mobile = new Mobile();
            mobile.Modelname = "motog4";
            Mobile.companyname = "motorola";
            Mobile.Getdata();
            Info();
            Console.Read();
        }
    }
}
