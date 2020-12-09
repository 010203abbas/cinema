using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers
{
    public class cinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insert()
        {
           
            return View();
        }
        public IActionResult Insertcomfirm()
        {
            return View();
        }
    }
}
