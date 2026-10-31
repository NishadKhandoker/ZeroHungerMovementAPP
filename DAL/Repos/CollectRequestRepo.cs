using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class CollectRequestRepo
    {
        HdbContext db;
        public CollectRequestRepo(HdbContext db) {  
            this.db = db; 
        }

        //create:
        public bool create(CollectRequest f)
        {
            db.CollectRequests.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public CollectRequest getbyid(int id)
        {
            var data = db.CollectRequests.Find(id);
            return data;
        }
        //getall:
        public List<CollectRequest> getall()
        {
            var data = db.CollectRequests.ToList();
            return data;
        }
        //update:
        public bool update(CollectRequest f)
        {
            var ex = db.CollectRequests.Find(f.CollectRequestId);
            ex.PreserveTime = f.PreserveTime;
            ex.Status = f.Status;
            ex.EmployeeId = f.EmployeeId;
            ex.RequestTime = f.RequestTime;
            ex.RestaurantId = f.RestaurantId;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(CollectRequest f)
        {
            var ex = db.CollectRequests.Find(f.CollectRequestId);
            db.CollectRequests.Remove(ex);
            return db.SaveChanges() > 0;
        }


        //all pending req
        public CollectRequest getPendingByRestaurant(int restaurantId)
        {
            return db.CollectRequests
                .FirstOrDefault(x =>
                    x.RestaurantId == restaurantId &&
                    x.Status == "Pending");
        }

    }
}
