using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmpDBDemo

{
    class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Did { get; set; }
        [Required]
        public string Dname { get; set; }
        public string Location { get; set; }
    }
}
