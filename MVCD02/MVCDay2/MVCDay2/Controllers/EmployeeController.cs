using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDay2.Models;

namespace MVCDay2.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ViewResult GetData()
        {
            return View();
        }

        //using post method
        [HttpGet]
        public ViewResult PostData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Welcome(int Id,string Name,string Address,int Age,decimal Salary)
        {
            return View();
        }

        //sending data from action to client 

        //1-ViewBag
        public ViewResult SendWithViewBag()
        {
            Employee e1 = new Employee { ID = 1, Name = "Mustafa", Address = "AbuHammad", Age = 22, Salary = 5000000 };
            ViewBag.emp1 = e1;
            return View();
        }

        //2-ViewData
        public ViewResult SendWithViewData()
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee{ID=1,Name="Mustafa",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=2,Name="Ahmed",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=3,Name="Mona",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=4,Name="Nada",Address="AbuHammad",Age=22,Salary=50000}

            };
            ViewData["ee"] = emps;
            return View();
        }


        //3-ViewModel
        public ViewResult SendWithViewModel()
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee{ID=1,Name="Mustafa",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=2,Name="Ahmed",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=3,Name="Mona",Address="AbuHammad",Age=22,Salary=50000},
                new Employee{ID=4,Name="Nada",Address="AbuHammad",Age=22,Salary=50000}

            };
            return View(emps);
        }

    }
}