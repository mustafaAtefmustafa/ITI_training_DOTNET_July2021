using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDay03.Models;

namespace MVCDay03.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext db = new CompanyContext();

        [HttpGet]
        public ActionResult Index()
        {
            var emp = db.Employees.ToList();
            return View(emp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        
        [HttpPost]
        public ActionResult Edit(Employee Emp)
        {
            var emp = db.Employees.FirstOrDefault(ww => ww.ID == Emp.ID);
            emp.Name = Emp.Name;
            emp.Age = Emp.Age;
            emp.Salary = Emp.Salary;
            emp.DeptId = Emp.DeptId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var emp = db.Employees.Find(id);
            return View(emp);

        }
         [HttpGet]
         public ActionResult Delete(int id)
        {
            var emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}