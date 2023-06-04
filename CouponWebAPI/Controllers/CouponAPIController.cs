using CouponWebAPI.Data;
using CouponWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CouponWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : Controller
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList(); 
                return objList; 

            }
            catch (Exception)
            {

               
            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Coupon objList = _db.Coupons.First(u=>u.CouponId == id);
                return objList;

            }
            catch (Exception)
            {

                throw;
            }
         
        }
    }
}
