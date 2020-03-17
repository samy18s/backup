using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDBFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities context = new EmployeeDBEntities();
            var Employee1 = context.Employees;
            Employee1.Add(new Employee { EmpID = 2, EName = "Tejaswini", Salary = 30000, DeptID = 2 });
            context.SaveChanges();

        }
    }
}
