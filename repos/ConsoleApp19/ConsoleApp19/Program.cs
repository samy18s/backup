using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 d = new Class1();
            double x = 10;
            double y = 10;
            double c = d.Addition(x, y);
            Console.WriteLine("add={0}", c);
             c = d.Subtraction (x, y);
            Console.WriteLine("sub={0}", c);
             c = d.Multiplication (x, y);
            Console.WriteLine("mul={0}", c);
             c = d.Division (x, y);
            Console.WriteLine("div={0}", c);
            demo e = new demo();
            e.msg();
            Console.ReadKey();
        }
    }
}
