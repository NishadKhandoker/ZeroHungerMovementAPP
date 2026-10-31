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
    public class RestaurantService
    {
        IMapper mapper;
        RestaurantRepo repo;
        public RestaurantService(IMapper mapper, RestaurantRepo repo)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        //create:
        public bool create(RestaurantModel f)
        {
            var data = mapper.Map<Restaurant>(f);
            return repo.create(data);
        }

        //get by id:
        public RestaurantModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<RestaurantModel>(data);
            return res;
        }
        //getall:
        public List<RestaurantModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<RestaurantModel>>(data);
            return res;
        }
        //update:
        public bool update(RestaurantModel f)
        {
            var data = mapper.Map<Restaurant>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(RestaurantModel f)
        {
            var data = mapper.Map<Restaurant>(f);
            return repo.delete(data);
        }


    }
}
