using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        public delegate void Print(int value1,int value2);


        static void Main(string[] args)
        {
            Print printdel = PrintSwap;

            printdel(18,12);
            
            
            Console.ReadKey();
        }

        public static void PrintSwap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("value of a i: {0}", +a+" Value of b " +b);
        }

        
    }

}
