using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        public delegate void Print(int value);


        static void Main(string[] args)
        {
            Print printdel = PrintNumber;

            printdel(10000);
            printdel(100);

            printdel = PrintMoney;

            printdel(10000);
            printdel(1000);

            Console.ReadKey();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money : {0:C}", money);

        }

    }

}
