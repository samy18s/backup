using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    class Program
    {
        //public void multipleof(int a, int b)
        //{

        //    console.writeline("the multiples of 3 starting from" + a + "to" + b + "are:");
        //    for (int i = a; i <= b; i++)
        //    {

        //        if (i % 3 == 0)
        //        {
        //            console.writeline(i);
        //        }

        //    }
        //}
        static void Main(string[] args)
        {
            Program1 p = new Program1();

            Console.WriteLine("Enter starting number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ending number");
            int b = Convert.ToInt32(Console.ReadLine());
            
            p.multipleof(a, b);

            Console.ReadKey();

        }
    }
}
