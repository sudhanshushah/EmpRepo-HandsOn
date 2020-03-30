using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeData.Models;
using EmployeeData.Repository;
using EmployeeData.Repository.Context;
using EmployeeData.Repository.Contract;

namespace EmployeeData.Controllers
{
    public class GetEmployeeController : Controller
    {
        // GET: GetEmployee
        public ActionResult Contents() 
        {
            return View();
        }
        public ActionResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputData(Employee e)
        {
            if (ModelState.IsValid)
            {
                IUnitOfWork unitofwork = new UnitOfWork(new EmpContext());
                unitofwork.Employees.Add(e);
                unitofwork.Complete();
                return View("Contents");
            }
            else
            {
                return View();
            }
        }
        public ActionResult ShowAll() 
        {
            IUnitOfWork uw = new UnitOfWork(new EmpContext());
            List<Employee> el = uw.Employees.GetAll().ToList();
            return View(el);
        }

        public ActionResult Delete(String id)
        {
            IUnitOfWork uw = new UnitOfWork(new EmpContext());
            Employee el = uw.Employees.Find(a => a.EmployeeID==Convert.ToInt32(id)).FirstOrDefault();
            uw.Employees.Remove(el);
            uw.Complete();
            return RedirectToAction("Contents");
        }
    }
}