using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "The Little Fox", Cuisine = CuisineType.none },
                new Restaurant { Id = 2, Name = "Pata Pata", Cuisine = CuisineType.African },
                new Restaurant { Id = 3, Name = "Wang Thai", Cuisine = CuisineType.Chinese },
                new Restaurant { Id = 4, Name = "Chalkboard", Cuisine = CuisineType.none },
                new Restaurant { Id = 5, Name = "Pizza Place", Cuisine = CuisineType.Italian }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(restaurant => restaurant.Name);
        }
    }
}
