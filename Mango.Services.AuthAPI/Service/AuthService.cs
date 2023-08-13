﻿using CouponWebAPI.Models.Dto;
using Mango.Services.AuthAPI.AuthModel;
using Mango.Services.AuthAPI.Data;
using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    { 
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(AppDbContext db 
                          ,UserManager<ApplicationUser> userManager
                          ,RoleManager<IdentityRole> roleManager) 
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;                
        }
        public Task<LoginRequestDto> Login(LoginRequestDto registrationRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Register(RegistrationRequestDTO registrationRequest)
        {
            throw new NotImplementedException();
        }
    }
}
