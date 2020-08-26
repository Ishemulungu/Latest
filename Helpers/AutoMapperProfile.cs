using AutoMapper;
using DeviceAPI.Dtos;
using DeviceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateDeviceDataDto, DeviceData>();
        }
    }
}
