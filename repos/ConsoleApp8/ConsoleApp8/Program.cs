using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //int j;
           int j = 10;
            //for(i=0;i<=10;i++)
            //for (i = 0,j=10; i <= 10 && j>=1; i++, j--)

            for (i =0;i<=10; i++, j--)
            {
                Console.WriteLine(" i ="+i+"   " + "j =" +j);
                //j--;
            }
            Console.ReadKey();
        }
    }
}
