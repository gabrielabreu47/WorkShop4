using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;
using WorkShop4.Model.Entities;

namespace WorkShop4.Bl.Mappings
{
    public class WorkShop4Profile : Profile
    {
        public WorkShop4Profile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
            CreateMap<Person, PersonDto>()
                .ReverseMap();
            CreateMap<Boss, BossDto>()
                .ReverseMap();
        }
    }
}
