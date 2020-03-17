using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpDBDemo
{
    class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Eid { get; set; }
        [Required]
        public string Ename { get; set; }
        public string Designation { get; set; }
        // Foreign key   
        [Display(Name = "Department")]
        public virtual int Did { get; set; }

        [ForeignKey("Did")]
        public virtual Department Departments { get; set; }
        //public int Did { get; set; }

        public double Salary { get; set; } 
    }
}
