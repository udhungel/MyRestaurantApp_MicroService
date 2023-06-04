using CouponWebAPI.Data;
using CouponWebAPI.Models;
using CouponWebAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CouponWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : Controller
    {
        private readonly AppDbContext _db;
        private ResponseDto _responseDto;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList(); 
                _responseDto.Result = objList;

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
               
            }
            return _responseDto;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Coupon objList = _db.Coupons.First(u=>u.CouponId == id);
                _responseDto.Result = objList;
                

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;

            }
            return _responseDto;
         
        }
    }
}
