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

        //  get request is generally used when there is a response / redirect action 
        //asp.net would default a request as get if there is no http attribute mentioned
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
           
            if (make==null) 
            {
                return NotFound();
            }
            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            var make = _db.Makes.Find(id);

            if (make == null)
            {
                return NotFound();
            }
            
            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {

            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
    }
}
