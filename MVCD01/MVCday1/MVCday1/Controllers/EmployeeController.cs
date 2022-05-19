using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCday1.Models;

namespace MVCday1.Controllers
{
    public class EmployeeController : Controller
    {
        DeptContext db = new DeptContext();

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(db.Employees.FirstOrDefault(e => e.ID == id), JsonRequestBehavior.AllowGet);
        }
    }
}