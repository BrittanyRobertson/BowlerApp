﻿using System;
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
            if (ModelState.IsValid)
            {
                _repo.CreateBowler(b);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Teams = _repo.Teams.ToList();
                return View(b);
            }
        }

        // Edit Bowler

        [HttpGet]
        public IActionResult EditBowler(int bowlerid)
        {
            ViewBag.Teams = _repo.Teams.ToList();

            _repo.GetBowler(bowlerid);
            return View("BowlerForm");
        }

        [HttpPost]
        public IActionResult EditBowler(Bowler b)
        {
            _repo.EditBowler(b);

            return RedirectToAction("Index");
        }


        // Delete Bowler
        [HttpGet]
        public IActionResult DeleteBowler(int bowlerid)
        {
            _repo.GetBowler(bowlerid);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteTask(Bowler b)
        {
            _repo.DeleteBowler(b);

            return RedirectToAction("Index");
        }
    }
}

