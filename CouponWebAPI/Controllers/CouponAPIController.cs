using AutoMapper;
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
        private IMapper _mapper;

        public CouponAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList(); 
                _responseDto.Result = _mapper.Map<IEnumerable<CouponDto>>(objList);

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
                _responseDto.Result = _mapper.Map<CouponDto>(objList);            

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;

            }
            return _responseDto;
         
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon objList = _db.Coupons.FirstOrDefault(u => u.CouponCode.ToLower() == code.ToLower());
                if (objList == null)
                {
                    _responseDto.IsSuccess = false;
                }
                _responseDto.Result = _mapper.Map<CouponDto>(objList);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }


        [HttpPost]
        
        public ResponseDto GetByCode([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Add(obj); // add to the coupon table and on line 92 it will go to DB and create the record 
                _db.SaveChanges(); //if you delete add update you need to savechanges in EF core

                _responseDto.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpPut]

        public ResponseDto put([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Update(obj);
                _db.SaveChanges(); 

                _responseDto.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }


        [HttpDelete]

        public ResponseDto Delete(int Id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u=>u.CouponId== Id); 
                _db.Coupons.Remove(obj);
                _db.SaveChanges();               
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
