using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmpDBDemo
{
    class EmpDepContext : DbContext

    {
        public EmpDepContext() : base("EmpDepContext") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
   
}
