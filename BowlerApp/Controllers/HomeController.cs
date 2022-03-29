using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BowlerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BowlerApp.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        // constructor
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(string team)
        {
            //var blah = _repo.Bowlers.ToList();
            IQueryable<Bowler> blah = _repo.Bowlers.Where(x => x.Team.TeamName == team || team == null);

            return View(blah);
        }

        [HttpGet]
        public IActionResult BowlerForm()
        {
            ViewBag.Teams = _repo.Teams.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult BowlerForm(Bowler b)
        {
            _repo.CreateBowler(b);

            return RedirectToAction("Index");
        }
    }
}
