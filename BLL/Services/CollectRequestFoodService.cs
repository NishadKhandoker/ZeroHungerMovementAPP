using AutoMapper;
using BLL.Models;
using DAL.EF;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CollectRequestFoodService
    {
        CollectRequestFoodRepo repo;
        CollectRequestRepo crepo;
        FoodRepo frepo;
        IMapper mapper;

        public CollectRequestFoodService(
            IMapper mapper,
            CollectRequestFoodRepo repo,
            CollectRequestRepo crepo,
            FoodRepo frepo)
        {
            this.mapper = mapper;
            this.repo = repo;
            this.crepo = crepo;
            this.frepo = frepo;
        }

        //create:
        public bool create(CollectRequestFoodModel f)
        {
            var request = crepo.getbyid(f.CollectRequestId);

            if (request == null)
            {
                return false;
            }

            if (request.Status != "Assigned")
            {
                return false;
            }

            var food = frepo.getbyid(f.FoodId);

            if (food == null)
            {
                return false;
            }
            

            var data = mapper.Map<CollectRequestFood>(f);

            return repo.create(data);
        }

        //get by id:
        public CollectRequestFoodModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<CollectRequestFoodModel>(data);
            return res;
        }
        //getall:
        public List<CollectRequestFoodModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<CollectRequestFoodModel>>(data);
            return res;
        }
        //update:
        public bool update(CollectRequestFoodModel f)
        {
            var data = mapper.Map<CollectRequestFood>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(CollectRequestFoodModel f)
        {
            var data = mapper.Map<CollectRequestFood>(f);
            return repo.delete(data);
        }
    }
}
