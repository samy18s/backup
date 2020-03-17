using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Domestic
    {
       // public double a;
        public double cost;

        public Domestic(double a)
        {
           double units_consumed=a;
        }

        public double Calculate(double units_consumed)
        {

        
            if (units_consumed > 0 && units_consumed <= 500)
            {
                cost = 0.75 * units_consumed;

            }
            else if (units_consumed >= 501 && units_consumed <= 1000)
            {
                cost = 2.35 * units_consumed;


            }
            else if (units_consumed >= 1001 && units_consumed <= 1500)
            {
                cost = 3.05 * units_consumed;

            }
            else if (units_consumed >= 1501 && units_consumed <= 2000)
            {
                cost = 4.00 * units_consumed;

            }
            else
            {
                cost = 5.15 * units_consumed;

            }
            return cost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, k;

            Console.WriteLine("Enter total units consumed by cutomer: ");
            i = Convert.ToDouble(Console.ReadLine());

            Domestic d = new Domestic(i);

            
            k = d.Calculate(i);
            Console.WriteLine("Total amount to be paid for domestic cutomer is {0}", k);
            j = k + (0.2 * k);
            Console.WriteLine("Total amount  to be paid for comercial customer is {0}", j);

            

            Console.ReadKey();
        }
    }

}
