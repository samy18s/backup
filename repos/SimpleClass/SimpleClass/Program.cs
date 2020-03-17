using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Employee
    {
        int EmpID;
        string EmpName;
        decimal Salary;

        public int ENo
        {
            get
            {
                return EmpID;
            }
            set
            {
                EmpID = value; 
            }
        }

        public string EName
        {
            get
            {
                return EmpName;
            }
            set
            {
                EmpName = value;
            }
        }

        public decimal Sal
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            Console.WriteLine("Enter the employee number ");
            e.ENo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the employee name ");
            e.EName = Console.ReadLine();

            Console.WriteLine("Enter the employee Salary ");
            e.Sal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Employee No " + e.ENo.ToString());
            Console.WriteLine("Employee Name " + e.EName.ToString());
            Console.WriteLine("Employee Salary " + e.Sal.ToString());

            Console.ReadKey();

        }
    }
}
