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
    public class FoodService
    {
        IMapper mapper;
        FoodRepo repo;
        public FoodService(IMapper mapper, FoodRepo repo)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        //create:
        public bool create(FoodModel f)
        {
            var data = mapper.Map<Food>(f);    
            return repo.create(data);
        }

        //get by id:
        public FoodModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<FoodModel>(data);
            return res;
        }
        //getall:
        public List<FoodModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<FoodModel>>(data);
            return res;
        }
        //update:
        public bool update(FoodModel f)
        {
            var data = mapper.Map<Food>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(FoodModel f)
        {
            var data = mapper.Map<Food>(f);
            return repo.delete(data);
        }


    }
}
