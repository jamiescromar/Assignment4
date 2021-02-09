using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class NewRestaurant
    {
        //This will make sure that the name is entered
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        //Restaurant name is required
        [Required(ErrorMessage = "Restaurant Name Required")]
        public string RestaurantName { get; set; }
        //Favorite dish is required
        [Required(ErrorMessage = "Favorite Dish Required")]
        public string FavoriteDish { get; set; }
        //This will produce an error messaage if the phone number is null
        [Required(ErrorMessage ="Phone Number Required")]
        //This will validate the the format of the phone number is xxx-xxx-xxxx
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Entered phone format is not valid. Correct format xxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }

    }
}
