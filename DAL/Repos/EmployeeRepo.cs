using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        HdbContext db;
        public EmployeeRepo(HdbContext db) { 
            this.db = db; 
        }


        //create:
        public bool create(Employee f)
        {
            db.Employees.Add(f);
            return db.SaveChanges() > 0;
        }

        //get by id:
        public Employee getbyid(int id)
        {
            var data = db.Employees.Find(id);
            return data;
        }
        //getall:
        public List<Employee> getall()
        {
            var data = db.Employees.ToList();
            return data;
        }
        //update:
        public bool update(Employee f)
        {
            var ex = db.Employees.Find(f.EmployeeId);
            ex.Name = f.Name;
            ex.ContactNo = f.ContactNo;
            return db.SaveChanges() > 0;
        }
        //delete:
        public bool delete(Employee f)
        {
            var ex = db.Employees.Find(f.EmployeeId);
            db.Employees.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
