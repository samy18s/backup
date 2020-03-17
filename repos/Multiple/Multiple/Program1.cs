using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    class Program1
    {
        public void multipleof(int start, int end)
        {

            Console.WriteLine("The multiples of 3 starting from" + start + "to" + end + "are:");

            int rem = start % 3;
            int result = 3 - rem;
            int initial = start + result;

            for (int i = initial; i <= end; i+=3)
            {

               // if (i % 3 == 0)
              //  {
                    Console.WriteLine(i);
               // }

            }
        }
    }
}
