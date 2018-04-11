using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        ICreature blobfish;

        public HomeController (ICreature blobfish)
        {
            this.blobfish = blobfish;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            
            return View(blobfish);
        }

        [HttpGet]
        [Route("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Login(string givenName)
        {
            blobfish.GiveName(givenName);
            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("cool")]
        public IActionResult Cool()
        {
            blobfish.WearSunglasses();
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("die")]
        public IActionResult Die()
        {
            blobfish.Die();
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("sad")]
        public IActionResult Sad()
        {
            blobfish.BeSad();
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("listen")]
        public IActionResult Listen()
        {
            blobfish.Music();
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("nutritionStore")]
        public IActionResult NutritionStore()
        {
            return View(blobfish);
        }

        [HttpGet]
        [Route("addnutrition")]
        public IActionResult AddNutrition(int i, int i2)
        {
            blobfish.AddFood(i);
            blobfish.AddDrink(i2);
            return RedirectToAction("nutritionstore");
        }
    }
}
