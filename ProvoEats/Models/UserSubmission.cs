using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoEats.Models
{
    public class UserSubmission
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }

        //This expression makes the user submit a number like so 123-456-7890
        [RegularExpression(@"^([0-9]{3})-([0-9]{3})-([0-9]{4})$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; }
    }
}
