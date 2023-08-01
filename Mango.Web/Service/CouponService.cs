using Mango.Web.Models;
using Mango.Web.Models.Dto;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        Task<ResponseDto?> ICouponService.CreateCouponAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto?> ICouponService.DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto?> ICouponService.GetAllCouponAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto?> ICouponService.GetCouponAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto?> ICouponService.GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto?> ICouponService.UpdateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}
