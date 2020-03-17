using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 d = new Class1();
            double number1 = 100;
            double number2 = 50;
            double result = d.Addition(number1, number2);
            
            Console.WriteLine(result);
            double m = d.Subtraction (number1, number2);
           
            Console.WriteLine (m);
            double l = d.Multiplication (number1, number2);
            
            Console.WriteLine(l);
            double k = d.Division (number1, number2);
           
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
