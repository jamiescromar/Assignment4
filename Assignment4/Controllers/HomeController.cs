using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
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
            //This declares and sets the variable equal to the list object
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.getRestaurants())
            {
                //Sets the value of Favorite dish to "Its all tasty" in the controller
                string? favDish = r.FavoriteDish ?? "It's all tasty";
                restaurantList.Add($"#{r.Rank}: Restaurant Name: {r.RestaurantName} Favorite Dish: {favDish} Restaurant Address: {r.Address} Phone Number: {r.PhoneNumber} Website: {r.Link}.");
            }
            return View(restaurantList);
        }
        //HttpGet when we go there for the first time
        [HttpGet]
        public IActionResult NewRestaurant()
        {
            return View();

        }

        //HttpPost: if the user clicks a button then that is a post
        [HttpPost]
        public IActionResult NewRestaurant(NewRestaurant restaurantResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurantResponse);
                Response.Redirect("RestaurantList");
                return View(restaurantResponse);
            }
            else
            {
                return View();
            }
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Restaurants);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
           // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
