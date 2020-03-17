using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class MyGeneric<G>
    {
        private G Genericvar;
        public MyGeneric(G value)
        {
            Genericvar = value;
        }
        public G GenericMethod(G Genericparam)
        {
            Console.WriteLine("Parameter is {0},value {1} ", typeof(G).ToString(), Genericparam);
            Console.WriteLine("String is {0}, value{1} ", typeof(G).ToString(), Genericvar);
            return Genericvar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> obj = new MyGeneric<int>(10);
            int val = obj.GenericMethod(200);

            MyGeneric<string> obj1 = new MyGeneric<string>("Hello there..");
            string value = obj1.GenericMethod("How's it going");

            Console.ReadKey();
        }
    }
}
