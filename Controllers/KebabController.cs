using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Controllers
{
    public class KebabController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
