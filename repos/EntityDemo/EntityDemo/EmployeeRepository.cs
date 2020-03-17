using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDemo
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            //return employeeDBContext.Departments.Include("Employees").ToList();

            //return employeeDBContext.Departments.Where(emp => emp.Location.Equals("Pune")).ToList();
            //var qry = from dep in employeeDBContext.Departments select dep;
            //return qry.ToList();

            var qry = from dep in employeeDBContext.Departments.Include("Employees") where dep.Location.Equals("Pune") select dep;
            return qry.ToList();
        }
    }
}