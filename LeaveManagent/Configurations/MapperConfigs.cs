﻿using AutoMapper;
using LeaveManagent.Data;
using LeaveManagent.Models;

namespace LeaveManagent.Configurations
{
    public class MapperConfigs : Profile
    {
        public MapperConfigs()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
        }
    }
}
