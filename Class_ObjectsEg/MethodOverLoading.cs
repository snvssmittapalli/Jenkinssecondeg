using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Shape
    {
        internal double Area(int r)
        {
            return (3.14 * r * r);
        }
        internal int Area(int l,int b)
        {
            return (l * b);
        }
    }
    class MethodOverLoading
    {
        static void Main()
        {
            Shape shape = new Shape();
            Console.WriteLine("area of circle {0}", shape.Area(4));
            Console.WriteLine("area of rectangle {0}", shape.Area(4,5));
            Console.Read();
        }
    }
}
