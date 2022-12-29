using jQueryLearnings.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CorrectUsageOfTryCatchInAjax()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            var person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        public IActionResult RetrieveDataUsingJQueryAndPromises()
        {
            return View();
        }

        public IActionResult GetAProductDetailsUsingJQueryAndPromises()
        {
            return View();
        }

        public IActionResult InsertProductUsingJQueryAndPromises()
        {
            return View();
        }

        public IActionResult UpdateProductUsingJQueryAndPromises()
        {
            return View();
        }

        public IActionResult DeleteProductUsingJQueryAndPromises()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EmployeeResultsInTable()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EmployeeResults()
        {
            return Json(Employees);
        }

        [HttpGet]
        public IActionResult DeferredObjectDemo()
        {
            return View();
        }

        public IActionResult DeferredObjectDemo2()
        {
            return View();
        }

        public IActionResult CachingWithDeferredObject()
        {
            return View();
        }

        public IActionResult WhichButtonPressed()
        {
            return View();
        }

        public IActionResult GetAndPostDataUsingAjax()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            var student = new Student()
            {
                Id = 1,
                Email = "email@gmail.com",
                Name = "Ashok Kumar"
            };
            return Json(student);
        }

        public List<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee { EmpId = 1001, EmpName = "Employee1", Salary = 100000, IsPermanent = true },
                    new Employee { EmpId = 1002, EmpName = "Employee2", Salary = 100001, IsPermanent = false },
                    new Employee { EmpId = 1003, EmpName = "Employee3", Salary = 100002, IsPermanent = true },
                    new Employee { EmpId = 1004, EmpName = "Employee4", Salary = 100003, IsPermanent = false }
                };
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
