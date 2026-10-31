using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<Food, FoodModel>().ReverseMap();
            CreateMap<Restaurant, RestaurantModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<CollectRequest, CollectRequestModel>().ReverseMap();
            CreateMap<CollectRequestFood, CollectRequestFoodModel>().ReverseMap();
            CreateMap<Distribution, DistributionModel>().ReverseMap();

        }
    }
}
