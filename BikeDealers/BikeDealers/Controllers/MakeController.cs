using BikeDealers.AppDbContext;
using BikeDealers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDealers.Controllers
{
    public class MakeController : Controller
    {
        private readonly BikeDbContext _db;

        public MakeController(BikeDbContext db)
        {
            _db = db;
        }
        public IActionResult Index() 
        {

            return View(_db.Makes.ToList());
        }
        // HTTP get Method
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {

            if (ModelState.IsValid) 
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        
        }
    }
}
