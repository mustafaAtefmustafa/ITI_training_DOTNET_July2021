using System;
using System.Data.Entity;
using System.Linq;

namespace MVCday1.Models
{
    public class DeptContext : DbContext
    {
        public DeptContext()
            : base("name=DeptContext")
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }


       

    
    }
}