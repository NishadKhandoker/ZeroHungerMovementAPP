using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class FoodRepo
    {
        HdbContext db;
        public FoodRepo(HdbContext db)
        {
            this.db = db;
        }


        //create:
        public bool create(Food f)
        {
            db.Foods.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public Food getbyid(int id)
        {
            var data = db.Foods.Find(id);
            return data;
        }
        //getall:
        public List<Food> getall()
        {
            var data = db.Foods.ToList();
            return data;
        }
        //update:
        public bool update(Food f) {
            var ex = db.Foods.Find(f.FoodId);
            ex.Name = f.Name;
            ex.Unit = f.Unit;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(Food f)
        {
            var ex = db.Foods.Find(f.FoodId);
            db.Foods.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
