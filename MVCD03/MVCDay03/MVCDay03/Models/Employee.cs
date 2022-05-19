using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay03.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int? Age { get; set; }
        public string Name { get; set; }
        public decimal? Salary { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}