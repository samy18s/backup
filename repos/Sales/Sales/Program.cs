using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int salescount;
            string name;
            double salary = 21000.0,com, total;

            Console.WriteLine("Enter  the Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter  the sales count");
            salescount = Convert.ToInt32(Console.ReadLine());

            if(salescount>=1000 && salescount<=4999)
            {
                Console.WriteLine("Sales person name  : " + name + "Salary" + salary + "Cash Incentive = 000");
            }


            else if (salescount >= 5000 && salescount <= 7499)
            {
                com = salary * 5 / 100;
                total = salary + com;
                Console.WriteLine("Sales person name  : " + name + "Salary" + total + "Cash Incentive = 000");
            }

            else if (salescount >= 7500 && salescount <= 10000)
            {
                com = salary * 12 / 100 ;
                salary = salary+com;
                Console.WriteLine("Sales person name  : " + name + "Salary" + salary + "Cash Incentive = 000");
            }

            else if ( salescount > 10000)
            {
                com = salary * 18 / 100;
                salary = salary + com + 1500;
                Console.WriteLine("Sales person name  : " + name + "Salary" + salary + "Cash Incentive = 1500");
            }

            Console.ReadKey();
        } 
      
        
    }
}
