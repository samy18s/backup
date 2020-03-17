using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;1<=10;i++)
            {
                Console.WriteLine(i.ToString());
                if((i%5)==0)
                {
                    return;
                }
            }
            Console.ReadKey(); 
        }
    }
}
