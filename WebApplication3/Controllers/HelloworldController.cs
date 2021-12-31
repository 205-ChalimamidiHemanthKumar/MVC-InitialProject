using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class HelloworldController : Controller
    {
        public string Index()
        {
            return "This is the default Action";
        }
        public string welcome()
        {
            return "This is a welcome action";
        }

    }
}
