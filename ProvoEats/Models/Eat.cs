using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoEats.Models
{
    public class Eat
    {
        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        public string FavoriteDish { get; set; }
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        //This constructor enables us to set the Rank initially, but then it is readonly.
        public Eat(int Rank)
        {
            this.Rank = Rank;
        }

        public static Eat[] GetEats()
        {
            Eat e1 = new Eat(1)
            {
                Name = "Culvers",
                FavoriteDish = "Mushroom Swiss Burger",
                Address = "111 Culver Lane, Provo UT 84606",
                Phone = "801-844-0321",
            };

            Eat e2 = new Eat(2)
            {
                Name = "Cafe Rio",
                FavoriteDish = "Sweet Pork Salad",
                Address = "111 Rio Road, Provo UT 84606",
                Phone = "801-844-0322",
                Website = "www.caferio.com"
            };

            Eat e3 = new Eat(3)
            {
                Name = "Red Robin",
                FavoriteDish = "Royal Red Robin Burger",
                Address = "111 Robin Road, Provo UT 84606",
                Phone = "801-844-0323",
                Website = "www.redrobin.com"
            };

            Eat e4 = new Eat(4)
            {
                Name = "Nico's Pizza",
                Address = "111 Nicos Lane, Provo UT 84606",
                Phone = "801-844-4545",
                Website = "www.nicospizza.com"
            };

            Eat e5 = new Eat(5)
            {
                Name = "Silver Dish Thai",
                FavoriteDish = "Coconut Curry",
                Address = "111 Center Street, Provo UT 84606",
                Phone = "801-844-4678",
                Website = "www.silverdishthai.com"
            };

            return new Eat[] { e1, e2, e3, e4, e5 };
        }
    }
}
