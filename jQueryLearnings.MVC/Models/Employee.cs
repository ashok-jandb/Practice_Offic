using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.MVC.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public bool IsPermanent { get; set; }
    }
}
