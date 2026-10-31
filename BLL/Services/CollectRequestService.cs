using AutoMapper;
using BLL.Models;
using DAL.EF;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BLL.Services
{
    public class CollectRequestService
    {
        IMapper mapper;
        CollectRequestRepo repo;
        RestaurantRepo rrepo;
        EmployeeRepo erepo;
        public CollectRequestService(IMapper mapper, CollectRequestRepo repo, RestaurantRepo    rrepo, EmployeeRepo erepo       )
        {
            this.mapper = mapper;
            this.repo = repo;
            this.rrepo = rrepo;
            this.erepo = erepo;
        }

        //create:
        public bool create(CollectRequestModel f)
        {
            if (rrepo.getbyid(f.RestaurantId) == null)
            {
                return false;
            }

            if (repo.getPendingByRestaurant(f.RestaurantId) != null)
            {
                return false;
            }

            if (f.PreserveTime <= DateTime.Now)
            {
                return false;
            }

            f.EmployeeId = null;
            f.RequestTime = DateTime.Now;
            f.Status = "Pending";

            var data = mapper.Map<CollectRequest>(f);

            return repo.create(data);
        }

        //assign employee:
        public bool assignEmployee(int requestId, int employeeId)
        {
            var request = repo.getbyid(requestId);

            if (request == null)
            {
                return false;
            }

            if (request.Status != "Pending")
            {
                return false;
            }

            var employee = erepo.getbyid(employeeId);

            if (employee == null)
            {
                return false;
            }

            request.EmployeeId = employeeId;
            request.Status = "Assigned";

            return repo.update(request);
        }

        //get by id:
        public CollectRequestModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<CollectRequestModel>(data);
            return res;
        }
        //getall:
        public List<CollectRequestModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<CollectRequestModel>>(data);
            return res;
        }
        //update:
        public bool update(CollectRequestModel f)
        {
            var data = mapper.Map<CollectRequest>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(CollectRequestModel f)
        {
            var data = mapper.Map<CollectRequest>(f);
            return repo.delete(data);
        }


    }
}
