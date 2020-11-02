using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Pen
    {
        public string brand;
        internal string color;
        internal int idno;


        // Constructor---special method,by default private

        internal Pen(int num)
        {
            idno = num;
                }
        internal Pen(string b, string c)
        {
            brand = b;
            color = c;
        }
        internal void DisplayPen()
        {
            Console.WriteLine("brand is {0}|| color is {1}", brand, color);
            
             
        }
        internal void Displaynum()
        {
            Console.WriteLine("id number {0}", idno);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            Pen pp1 = new Pen(123);
            Pen pen = new Pen("parker", "blue");
            pen.DisplayPen();
            pp1.Displaynum();
            Console.Read();


        }
    }
}
