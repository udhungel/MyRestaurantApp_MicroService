﻿using Mango.Web.Models;
using Mango.Web.Models.Dto;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponAsync(string couponCode);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsync(int id);

    }
}
-