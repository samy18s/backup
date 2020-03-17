using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDBDemo
{
    class Program
    {
        static void Main(string[] args)
            {
                
            DeptInsert();
            insertData();
            //show();

        }

           /* private static void show()
            {
                EmpDepContext pdx = new EmpDepContext;
                var products = pdx.Products;

                foreach (var prd in products)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Ptitle, prd.Price);
                    Console.ReadKey();
                }
            }*/

            private static void insertData()
            {
                EmpDepContext emp = new EmpDepContext();
                Console.WriteLine("Enter Emplpoyee ID");
                int eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter Designtion");
                string designation = Console.ReadLine();
                Console.WriteLine("Enter the Dept id");
                int did = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the salary");
                double salary = Convert.ToDouble(Console.ReadLine());
                Employee ed = new Employee { Eid = eid, Ename = ename, Designation=designation,Did=did,Salary=salary };

                emp.Employees.Add(ed);
                emp.SaveChanges();


            }

        private static void DeptInsert()
        {
            EmpDepContext empx = new EmpDepContext();
            Console.WriteLine("Enter the Dept id");
            int did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department name");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter Department location");
            string location = Console.ReadLine();
            Department d2 = new Department { Did = did, Dname = dname, Location = location };
            empx.Departments.Add(d2);
            empx.SaveChanges();

        }

    }
}
