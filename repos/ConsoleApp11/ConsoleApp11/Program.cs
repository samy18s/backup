using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Student
    {
        int a , b ,c;

        public int  add(int a,int b)
        {
                   c = a + b;
            return c;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Student s = new Student();

            Console.WriteLine("Enter the value of i: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of j: ");
            j = Convert.ToInt32(Console.ReadLine());

            k = s.add(i,j);
            Console.Write("Result is {0}", k);
            Console.ReadKey();
        }
    }
}
