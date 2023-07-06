using AutoMapper;
using Registration.Common.DTOs;
using Registration.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();

        }
    }
}
