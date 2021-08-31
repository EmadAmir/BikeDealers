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
    }
}
