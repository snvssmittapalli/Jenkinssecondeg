using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3assignment
{
    class Productdetails
    {
        internal int pid;
        internal string pname;
        internal int price;
        internal static string shopname;
        internal Productdetails(int pid, string pname, int price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
        }
        internal void Displaydetails()
        {
            Console.WriteLine("productid is {0}||product name is {1}|| product price {2}||shopname is {3}", pid, pname, price, shopname);

        }
    }
    class Product
    {
        static void Main()
        {
            Console.WriteLine("enter shopname");
            Productdetails.shopname = Console.ReadLine();

            int productid, cost;
            string productname;
            Console.WriteLine("enter number of products do u wnat to enter");
            int no = Convert.ToInt32(Console.ReadLine());
            Productdetails[] productdetails = new Productdetails[no];
            for (int i = 0; i < productdetails.Length; i++)
            {
                Console.WriteLine("enter the product id product name and cost");
                productid = Convert.ToInt32(Console.ReadLine());
                productname = Console.ReadLine();
                cost = Convert.ToInt32(Console.ReadLine());
                productdetails[i] = new Productdetails(productid, productname, cost);

            }
            for (int i = 0; i < productdetails.Length; i++)
            {
                productdetails[i].Displaydetails();
            }
            Console.ReadLine();
        }
    }
}
