using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter theb value of b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is " + (a + b).ToString());
            Console.ReadKey();
        }
    }
}
