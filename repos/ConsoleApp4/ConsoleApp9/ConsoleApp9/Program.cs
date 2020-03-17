using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Demo
    {
        int a;

        public int A
        {
            get
            {
                return a;

            }

            set
            {
                a = value;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Demo D = new Demo();

            D.A = 10;

            Console.WriteLine(D.A.ToString());

            Console.ReadKey();
        }
    }
}

