using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public interface Demo
    {

        void square();          
        
    }

    public interface Demo1
    {
          void cube();
         
    }
    public class Multiplication : Demo, Demo1
    {
        public void cube()
        {
            int x=6;
            Console.WriteLine("square is {0}",x * x);


        }

        public void square()
        {
            int x = 6;
            Console.WriteLine("cube is {0}", x * x * x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication m = new Multiplication();
            m.square();
            m.cube();

            Console.ReadKey();
        }
    }
}
