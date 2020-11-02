using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3assignment
{
    class Swapping
    {
        internal  void Swapp(int n1, int n2)
        {
            int n3 = n1;
            n1 = n2;
            n2 = n3;
            Console.WriteLine("after swapping  n1={0},n2 {1}", n1, n2);
        }
        internal void Swapp(string p, string q)
        {
            string r = p;
            p = q;
            q = r;
            Console.WriteLine("after swapping  p={0},q is {1}", p, q);

        }




    }
    class Swap
    {
        static void Main()
        {
            Console.WriteLine(" Enter number one ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter number two ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter string one ");

            string c = Console.ReadLine();

            Console.WriteLine(" Enter string two ");

            string d = Console.ReadLine();

            Swapping swapping = new Swapping();

            Swapping swapping1 = new Swapping();

            swapping.Swapp(a, b);

            swapping1.Swapp(c, d);

            Console.Read();


        }
    }
}
