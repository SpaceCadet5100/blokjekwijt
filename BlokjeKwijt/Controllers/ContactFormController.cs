﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Controllers
{
    public class ContactFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
