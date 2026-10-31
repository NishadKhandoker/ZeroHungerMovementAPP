using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class RestaurantRepo
    {
        HdbContext db;
        public RestaurantRepo(HdbContext db)
        {
            this.db = db;   
        }


        //create:
        public bool create(Restaurant f)
        {
            db.Restaurants.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public Restaurant getbyid(int id)
        {
            var data = db.Restaurants.Find(id);
            return data;
        }
        //getall:
        public List<Restaurant> getall()
        {
            var data = db.Restaurants.ToList();
            return data;
        }
        //update:
        public bool update(Restaurant f)
        {
            var ex = db.Restaurants.Find(f.RestaurantId);
            ex.Name = f.Name;
            ex.ContactNo = f.ContactNo;
            ex.Address = f.Address;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(Restaurant f)
        {
            var ex = db.Restaurants.Find(f.RestaurantId);
            db.Restaurants.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
