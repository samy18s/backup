﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
            public double Addition(double x, double y)
            {
                return x + y;
            }
            public double Subtraction(double x, double y)
            {
                return x - y;
            }
            public double Multiplication(double x, double y)
            {
                return x * y;
            }
            public double Division(double x, double y)
            {
                return x / y;
            }
    }
    interface sample
    {
       void msg();
    }
    public class demo : sample
    {
        public void msg()
        {
            Console.WriteLine("LOLITA---6IX");
        }
    }
}
