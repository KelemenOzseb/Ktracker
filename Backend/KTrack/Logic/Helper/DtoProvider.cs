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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewDto>();
                cfg.CreateMap<RegistrationDto, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));
                cfg.CreateMap<UpdateUserDto, User>()
                .AfterMap((src, dest) =>
                {
                    if (!string.IsNullOrEmpty(src.Password))
                    {
                        var passwordHasher = new PasswordHasher<User>();
                        dest.PasswordHash = passwordHasher.HashPassword(dest, src.Password);
                    }
                });
            });
            Mapper = new Mapper(config);
        }
    }
}
