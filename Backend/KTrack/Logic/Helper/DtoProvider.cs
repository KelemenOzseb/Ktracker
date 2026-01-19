using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Entities.Dtos.User;

namespace Logic.Helper
{
    public class DtoProvider 
    {
        public Mapper Mapper { get; }

        public UserManager<User> UserManager;

        public DtoProvider(UserManager<User> userManager)
        {
            this.UserManager = userManager;
            var Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewDto>();
            });
        }
    }
}
