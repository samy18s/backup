using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    using System;
    namespace CallByValue
    {
        class Program
        {
            // User defined function  
            public int Show(int val)
            {
                val *= val; // Manipulating value  
                Console.WriteLine("Value inside the show function " + val);
                return val;
                // No return statement  
            }
            // Main function, execution entry point of the program  
            static void Main(string[] args)
            {
                int val = 50;
                Program program = new Program(); // Creating Object  
                Console.WriteLine("Value before calling the function " + val);
                program.Show(val); // Calling Function by passing value            
                Console.WriteLine("Value after calling the function " + val);
                Console.ReadKey();
            }
        }
    }
}
    