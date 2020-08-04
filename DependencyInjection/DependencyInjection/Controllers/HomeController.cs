using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _Employee = null;
        private IStudent _Student = null;


        public HomeController(IEmployee employee,IStudent student) 
        {
            //_Employee = new Employee();
            _Employee = employee;
            _Student= student;
        }
        public ActionResult Index()
        {
            int cnt = _Employee.GetToalEmp();
            bool data = _Student.IsStudent();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}