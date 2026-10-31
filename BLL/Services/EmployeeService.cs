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
    public class EmployeeService
    {
        IMapper mapper;
        EmployeeRepo repo;
        public EmployeeService(IMapper mapper, EmployeeRepo repo)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        //create:
        public bool create(EmployeeModel f)
        {
            var data = mapper.Map<Employee>(f);
            return repo.create(data);
        }

        //get by id:
        public EmployeeModel getbyid(int id)
        {
            var data = repo.getbyid(id);
            var res = mapper.Map<EmployeeModel>(data);
            return res;
        }
        //getall:
        public List<EmployeeModel> getall()
        {
            var data = repo.getall();
            var res = mapper.Map<List<EmployeeModel>>(data);
            return res;
        }
        //update:
        public bool update(EmployeeModel f)
        {
            var data = mapper.Map<Employee>(f);
            return repo.update(data);
        }
        //delete:
        public bool delete(EmployeeModel f)
        {
            var data = mapper.Map<Employee>(f);
            return repo.delete(data);
        }


    }
}
