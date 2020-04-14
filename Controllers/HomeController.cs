using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlienOnsies.Models;

namespace AlienOnsies.Controllers
{
    public class HomeController : Controller
    {
        static List<Onsie> Stock = new List<Onsie>()
            {
                new Onsie()
                {
                    Fabric = "100% Genuine Polyester",
                    Alien = "Xenomorph",
                    Color ="Grey",
                    ImgUrl = "https://www.4kigurumi.com/image/cache/data/kigurumi/D011/alien-kigurumi-onesie-5-600x900.jpg",
                    isFooted = false,
                    Price = 59.99M
                },
                new Onsie()
                {
                    Fabric = "Satin",
                    Alien = "Totoro",
                    Color ="Greige",
                    ImgUrl = "https://www.onesieshow.com/media/catalog/product/cache/1/image/448x597/9df78eab33525d08d6e5fb8d27136e95/y/a/yaw712026.jpg",
                    isFooted = false,
                    Price = 19.99M
                }
            };

        [HttpGet("")]
        public IActionResult Index()
        {
            string welcome = "This is a site dedicated to delivering the best alien onsies";

            return View("Index",welcome);
        }

        [HttpGet("onsies")]
        public IActionResult Onsies()
        {
            return View(Stock);
        }

        [HttpPost("create")]
        public IActionResult CreateOnsie(Onsie newOnsie)
        {
            Stock.Add(newOnsie);
            return Redirect("/onsies");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
