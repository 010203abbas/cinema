using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using cinema.Models;
using cinema.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cinema.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Insert()
        {
            DBcinema db = new DBcinema();
            ViewData["countries"] = db.Countries.ToList();
            return View();
        }
        
        public IActionResult Insertcomfirm(FilmViewModel model)
        {
            Film a = new Film();
            a.Name =model.Name ;
          a.Year = model.Year  ;
          a.CountryId  =model.CountryId  ;
            DBcinema b = new DBcinema();
            b.Add(a);
            b.SaveChanges();

            return RedirectToAction("Insert","Film");  

        }
        public IActionResult  Lst()
        {
            DBcinema obj = new DBcinema();
            List<Film> films = obj.Films.Include(x => x.Country).ToList();
            return View(films);
        }


    }
}
