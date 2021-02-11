using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoEats.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProvoEats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //This list will be used for a string that will be displayed on the page.
            List<string> eatList = new List<string>();
            
            foreach(Eat eat in Eat.GetEats())
            {
                eatList.Add($"#{eat.Rank}: {eat.Name}    |   Favorite Dish: {eat.FavoriteDish ?? "It's all tasty!"}   |   Address: {eat.Address}   |   Phone: {eat.Phone ?? "No phone listed."}    |     Website: {eat.Website ?? "Coming Soon"}");
            }

            return View(eatList);
        }

        public IActionResult Submissions()
        {
            //Pass the page the tempstorage for iteration.
            return View(TempStorage.Submissions);
        }

        [HttpGet]
        public IActionResult SubmitEat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitEat(UserSubmission usersubmission)
        {
            //Checks to see if the model is right.
            if (ModelState.IsValid)
            {
                //This checks to see if the user submitted a favorite dish before adding it to the tempstorage list.
                usersubmission.FavoriteDish = usersubmission.FavoriteDish ?? "It's All Tasty";

                TempStorage.AddSubmission(usersubmission);

                //Take the user to a brief confirmation page.
                return View("Confirmation");
            }
            //If things don't check out, keep the user on the page and dont add any objects.
            else
            {
                return View();
            }

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
