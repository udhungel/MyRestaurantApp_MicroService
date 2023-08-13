using CouponWebAPI.Models.Dto;
using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {      

        Task<UserDto> Register(RegistrationRequestDTO registrationRequest);
        Task<LoginRequestDto> Login(LoginRequestDto registrationRequest);    

    }
}
