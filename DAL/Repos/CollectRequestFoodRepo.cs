using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class CollectRequestFoodRepo
    {
        HdbContext db;
        public CollectRequestFoodRepo(HdbContext db) { 
            this.db = db; 
        }  

        //create:
        public bool create(CollectRequestFood f)
        {
            db.CollectRequestFoods.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public CollectRequestFood getbyid(int id)
        {
            var data = db.CollectRequestFoods.Find(id);
            return data;
        }
        //getall:
        public List<CollectRequestFood> getall()
        {
            var data = db.CollectRequestFoods.ToList();
            return data;
        }
        //update:
        public bool update(CollectRequestFood f) {
            var ex = db.CollectRequestFoods.Find(f.CollectRequestFoodId);
            ex.CollectRequestId = f.CollectRequestId;
            ex.FoodId = f.FoodId;
            ex.Qnt = f.Qnt;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(CollectRequestFood f)
        {
            var ex = db.CollectRequestFoods.Find(f.CollectRequestFoodId);

            if (ex == null)
                return false;

            db.CollectRequestFoods.Remove(ex);

            return db.SaveChanges() > 0;
        }
    }
}
