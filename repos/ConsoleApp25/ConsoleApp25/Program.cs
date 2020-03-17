using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> MyD = new Dictionary<int, int>();
            int i;
             
            for(i=1;i<=25;i++)
            {
                MyD.Add(i, i);
            }

            foreach(var result in MyD)
            {
                Console.WriteLine(result.ToString());
            }
            Console.WriteLine("Element of my dictionary is {0}", MyD[3].ToString());

            Console.ReadKey();
        }
    }
}
