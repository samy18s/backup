using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Demo
    {
        public int Square(out int x )
        {
            Console.Write("Enter the value for x");
            x = Convert.ToInt32(Console.ReadLine());
            return x * x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            int i=5, j;
            j = d.Square(out i);
            Console.WriteLine("Result is {0}", j);

            Console.ReadKey();
        }
    }
}
