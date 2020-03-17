using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)$";
            Regex rx = new Regex(pattern);
            Console.WriteLine(rx.IsMatch("@dev@test.com").ToString());

            Regex rx2 = new Regex("[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)");
            MatchCollection mc = rx2.Matches("My emails are dd@test.com and sd@pp.com");
            foreach(Match item in mc)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
