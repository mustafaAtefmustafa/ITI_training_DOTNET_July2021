using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCday1.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"{ID},{Age},{Name},{Salary}";
        }

    }
}