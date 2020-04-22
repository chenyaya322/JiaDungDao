using System;
using System.Collections.Generic;
using System.Linq;
using Back_End.Interface;
using Back_End.Models;
using JiaDungDao.Connection;

namespace Back_End.Repositories {
    public class RestaurantRepo : IRestaurantRepo {
        private readonly ApplicationDbContext db;
        public RestaurantRepo (ApplicationDbContext dbContext) {
            this.db = dbContext;
        }

        public List<Menu> GetAllMenuById (int Id) {
            var allMenu = db.Menu.Where (m => m.RestaurantID == Id).OrderBy (m => m.m_type).ToList ();
            return allMenu;
        }

        public List<string> GetAllMenuTypeById (int Id) {
            var allMenuType = db.Menu.Where (m => m.RestaurantID == Id).OrderBy (m => m.m_type).Select (m => m.m_type).Distinct ().ToList ();
            return allMenuType;
        }

        public List<Restaurant> GetAllRestaurant () {
            var result = db.Restaurant.ToList ();
            if (result != null) {
                return result;
            } else {
                return null;
            }
        }

        public Restaurant GetRestaurantById (int Id) {
            var result = db.Restaurant.Where (r => r.RestaurantID == Id).FirstOrDefault ();
            if (result != null) {
                return result;
            } else {
                return null;
            }
        }

        public string updateRestaurant (Restaurant restaurant) {
            var result = string.Empty;
            try {
                var updateRestaurant = db.Restaurant.Where (r => r.RestaurantID == restaurant.RestaurantID).FirstOrDefault ();
                updateRestaurant.r_name = restaurant.r_name;
                updateRestaurant.r_address = restaurant.r_address;
                updateRestaurant.r_tel = restaurant.r_tel;
                updateRestaurant.m_account = restaurant.m_account;
                var Count = db.SaveChanges ();
                return (Count > 0) ? "success" : "fail";
            } catch (Exception e) {
                return e.ToString ();
                throw;
            }
        }
    }
}