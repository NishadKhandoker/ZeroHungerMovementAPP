using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class DistributionRepo
    {
        HdbContext db;
        public DistributionRepo(HdbContext db) { 
            this.db = db; 
        }

        //create:
        public bool create(Distribution f)
        {
            db.Distributions.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public Distribution getbyid(int id)
        {
            var data = db.Distributions.Find(id);
            return data;
        }
        //getall:
        public List<Distribution> getall()
        {
            var data = db.Distributions.ToList();
            return data;
        }
        //update:
        public bool update(Distribution f)
        {
            var ex = db.Distributions.Find(f.DistributionId);
            ex.DistributedAt = f.DistributedAt;
            ex.CollectRequestId = f.CollectRequestId;
            ex.EmployeeId = f.EmployeeId;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(Distribution f)
        {
            var ex = db.Distributions.Find(f.DistributionId);
            db.Distributions.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
