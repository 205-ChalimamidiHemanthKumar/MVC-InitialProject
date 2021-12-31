using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Employee Name";
        }
        public string FirstName()
        {
            return "Employee FirstName: Hemanth";
        }
        public string LastName()
        {
            return "Employee LastName: Kumar";
        }
    }
}
