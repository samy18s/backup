using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayer dl = new DataLayer();
            Console.WriteLine("-------------Employee Details--------------");
            Console.WriteLine("1.Insert \n 2.Update \n 3.Display");
            int ch;
            char c;
            do
            {
                
                Console.WriteLine("Enter your choice :");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        dl.insert();
                        break;

                    case 2:
                        dl.update();
                        break;

                    case 3:
                        dl.display();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

                Console.WriteLine("Do you want to continue(y/n)");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
            
            Console.ReadKey();
        }
    }
}
