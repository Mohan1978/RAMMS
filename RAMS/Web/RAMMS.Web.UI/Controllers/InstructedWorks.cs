﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAMMS.Web.UI.Controllers
{
    public class InstructedWorks : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddFormW1()
        {
            return View("~/Views/InstructedWorks/AddFormW1.cshtml");
        }

        public IActionResult AddFormW2()
        {
            return View("~/Views/InstructedWorks/AddFormW2.cshtml");
        }
    }
}
