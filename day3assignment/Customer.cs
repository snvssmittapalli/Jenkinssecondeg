using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace day3assignment
{
    class CustomerDetails
    {
        internal int customerid;
        internal int age;
        internal int phone;
        internal string name;
        internal string city;

        // constructor taking all arguments
        internal CustomerDetails(int customerid, int age, int phone, string name, string city)
        {
            this.customerid = customerid;
            this.age = age;
            this.phone = phone;
            this.name = name;
            this.city = city;
        }
        //constuctor with zero arguments
        internal CustomerDetails()
        {
            Console.WriteLine("---------");
        }
        internal void DisplayCustomer()
        {
            Console.WriteLine("customerid is {0}|| customer age is {1}||customer name is {2}|| customer phone num is {3}|| city is {4}",customerid,age,name,phone,city);


        }

    }
    class Customer
    {
        static void Main()
        {
            Console.WriteLine("enter no of customers");
            int no = Convert.ToInt32(Console.ReadLine());
            CustomerDetails[] customerdetails = new CustomerDetails[no];
            CustomerDetails[] cusde = new CustomerDetails[no];
            for (int i = 0; i < customerdetails.Length; i++)
            {
                Console.WriteLine("enter cid,name,age,phone,city");
                int cid = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                int phone = Convert.ToInt32(Console.ReadLine());
                string city = Console.ReadLine();
                customerdetails[i] = new CustomerDetails(cid, age, phone, name, city);
                cusde[i] = new CustomerDetails();


            }
            for (int i = 0; i < customerdetails.Length; i++)
            {
                customerdetails[i].DisplayCustomer();
                cusde[i].DisplayCustomer();

            }
            Console.ReadLine();
        }
    }
}
