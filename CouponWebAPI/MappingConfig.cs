using AutoMapper;
using CouponWebAPI.Models;
using CouponWebAPI.Models.Dto;

namespace CouponWebAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();  
        }
        //public static MapperConfiguration RegisterMaps()            
        //{
        //    var mappingConfig = new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<CouponDto,Coupon>();
        //        config.CreateMap<Coupon, CouponDto>();
        //    });
        //    return mappingConfig;
        //}
    }
}
