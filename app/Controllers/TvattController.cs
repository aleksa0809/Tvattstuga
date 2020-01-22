using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;
using app.Data;

namespace app.Controllers
{
    public class TvattController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TvattController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Bad(){
            return View();
            
        }
        
        public IActionResult Add([FromServices] ApplicationDbContext context,[Bind("TvattDate")] Tvatt tvatt)
        {
            tvatt.User = User.Identity.Name;

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Bad");
            }
            context.Tvatts.Add(tvatt);
            context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Index()//pokazivaet vse stirki
        {
            return RedirectToAction("List");

        }
        public IActionResult List([FromServices] ApplicationDbContext context)//pokazivaet vse stirki
        {
            var tvatts = context.Tvatts.ToList();
            ViewData["tvatts"] = tvatts;
            return View(new Tvatt());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
