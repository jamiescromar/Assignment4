using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        //This is creating a new list object from the models file "New Restaurant Response"
        private static List<NewRestaurant> restaurants = new List<NewRestaurant>();

        //Enumerate a list
        public static IEnumerable<NewRestaurant> Restaurants => restaurants;

        public static void AddRestaurant(NewRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
