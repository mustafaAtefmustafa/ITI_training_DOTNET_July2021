﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDay03.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}