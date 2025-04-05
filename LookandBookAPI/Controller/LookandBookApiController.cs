using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LookandBookAPI.Models;
using LookandBookAPI.Data;

namespace LookandBookAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookandBookApiController : ControllerBase
    {
        private readonly ApiContext _context;

        public LookandBookApiController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if(booking.Id == 0)
            {
                _context.HotelBooking.Add(booking);
            }
            else
            {
                var bookingInDb = _context.HotelBooking.Find(booking.Id);

                if (bookingInDb == null)
                    return new JsonResult(NotFound());

                bookingInDb = booking;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(booking));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.HotelBooking.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));

        }
    }
}
