﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB510.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
