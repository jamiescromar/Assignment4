using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        //This is the controller that will allow us to specify the rank in the parenthesis when declaring values
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        //This will amke sure that the rank is required
        [Required(ErrorMessage = "Rank Required")]
        public int Rank { get; }
        //validate that REstauraunt name is not null
        [Required(ErrorMessage = "Resturaunt Name Required")]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        //Validate that the address is not null
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        //This will make it so that if the link value is null it will autmatically set the value to coming soon
        public string? Link { get; set; } = "Coming Soon";

        //Create values to store to the variables that were created in the model
        //This is also a method that you will be able to call to get the restaurants 
        public static Restaurant[] getRestaurants()
        {
            Restaurant R1 = new Restaurant(1)
            {
                RestaurantName = "SLABpizza",
                FavoriteDish = "BBQ Chicken Pizza",
                Address = "671 E 800 N, Provo, UT 84606",
                PhoneNumber = "8013773883",
                Link = "https://www.slabpizza.com/menu"
            };
            Restaurant R2 = new Restaurant(2)
            {
                RestaurantName = "Chick-fil-A",
                Address = "484 Bulldog Ln, Provo, UT 84604",
                PhoneNumber = "8013742697",
                Link = "https://www.chick-fil-a.com/"
            };
            Restaurant R3 = new Restaurant(3)
            {
                RestaurantName = "Jamba Juice",
                FavoriteDish = "Island Pitaya Bowl",
                Address = "1774 N University Pkwy #60, Provo, UT 84604",
                PhoneNumber = "8013770404",
                Link = "https://www.jamba.com/ut/provo/provo-201?utm_source=google&utm_medium=organic&utm_campaign=localmaps"
            };
            Restaurant R4 = new Restaurant(4)
            {
                RestaurantName = "Crumbl Cookies",
                FavoriteDish = "Chocolate Chip Cookies",
                Address = "152 W 1230 N St, Provo, UT 84604",
                PhoneNumber = "8018231544",
                Link = "https://crumblcookies.com/Provo"
            };
            Restaurant R5 = new Restaurant(5)
            {
                RestaurantName = "Noodles & Company",
                FavoriteDish = "Steak Stroganoff",
                Address = "62 West Bulldog Blvd, Provo, UT 84604",
                PhoneNumber = "8018231544",
                Link = "8013739670"
            };
            return new Restaurant[] { R1, R2, R3, R4, R5 };
        }
    }
}
