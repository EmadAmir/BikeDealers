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
        //Make/bikes
        [Route("Make")]
        [Route("Make/Bikes")]
        public IActionResult Bikes()
        {
            
            Make make = new Make { Id =1, Name = "Harley Davidson"};
            return View(make);
           // ContentResult CR = new ContentResult { Content = "Hello World" };
            //return CR;
        }
        [Route("make/bikes/{year:int:length(4)}/{month:int:range(1,13)}")]
        public IActionResult ByYearMonth(int year, int month) {

            return Content(year+";"+ month);
        }
    }
}
