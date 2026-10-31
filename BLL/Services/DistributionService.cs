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
    public class DistributionService
    {
        IMapper mapper;
        DistributionRepo repo;
        public DistributionService(IMapper mapper, DistributionRepo repo)
        {
            this.mapper = mapper;
            this.repo =  repo;
        }

        //create:
        public bool create(DistributionModel f)
        {
            var data = mapper.Map<Distribution>(f);
            return repo.create(data);
        }

        //get by id:
        public DistributionModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<DistributionModel>(data);
            return res;
        }
        //getall:
        public List<DistributionModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<DistributionModel>>(data);
            return res;
        }
        //update:
        public bool update(DistributionModel f)
        {
            var data = mapper.Map<Distribution>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(DistributionModel f)
        {
            var data = mapper.Map<Distribution>(f);
            return repo.delete(data);
        }



    }
}
