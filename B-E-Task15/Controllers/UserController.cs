using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B_E_Task15.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Amir";
            ViewBag.Surname = "Khan";
            ViewBag.Age = 55;
            ViewBag.Country = "Dehli";
            ViewBag.PhoneNumber = "+233 023 222 03";
            return View();
        }
    }
}
