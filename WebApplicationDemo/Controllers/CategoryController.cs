﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
