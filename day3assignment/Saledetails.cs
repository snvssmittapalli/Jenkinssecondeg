using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3assignment
{
    class Salesinformation
    {
       internal  int salesnum;
        internal int productno;
        internal int price;
        internal int quantity;
        internal string dateofsale;
        internal int totalprice;
        

        internal Salesinformation(int salesnum, int productno, int price, int quantity,string dateofsale)
        {
            this.salesnum = salesnum;
            this.productno = productno;
            this.price = price;
            this.quantity = quantity;
            this.dateofsale = dateofsale;

        }
        
        internal int Salestotal(int quantity,int price)
        {
            return (quantity * price);

        }
        /*  internal void Totalamount()
          {
              Console.WriteLine("total aount is {0}", (price * quantity));

          } */
        internal void Totalinformation()

        {
            totalprice = Salestotal(price, quantity);
            Console.WriteLine("salesnum is {0}||product numis {1}|| price is {2} || quantity is {3}|| total price is {4}||date is {5}", salesnum, productno, quantity, price, totalprice,dateofsale);



        }
    }
    class Saledetails
    {
        static void Main()
        {
            Console.WriteLine("enter no of salesitem");
            int size = Convert.ToInt32(Console.ReadLine());
            
            Salesinformation[] salesinformation = new Salesinformation[size];
            Console.WriteLine("enter salesnum ,productnum,price,quantity");
            for (int i = 0; i < salesinformation.Length; i++)
            {
                int salesnum = Convert.ToInt32(Console.ReadLine());
                int productnum = Convert.ToInt32(Console.ReadLine());
                int price = Convert.ToInt32(Console.ReadLine());
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(DateTime.Now.ToShortDateString());
                string date = Console.ReadLine();
               // DateTime date = Convert.ToDateTime(Console.ReadLine());
                salesinformation[i] = new Salesinformation(salesnum, productnum, price, quantity,date);
            }
            for (int i = 0; i < salesinformation.Length; i++)
            {
              
                salesinformation[i].Totalinformation();
            }
            Console.ReadLine();







            }
    }
}
