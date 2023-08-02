using Bookings.Interfaces;
using Bookings.Models;
using Bookings.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookings.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TourBookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public TourBookingController(IBookingService bookingService)
        {
            _bookingService=bookingService;
        }

        [HttpPost]
        public async Task<ActionResult<TourBooking?>> BookTour(TourBooking tour)
        {
            var newTour = await _bookingService.BookTrip(tour);
            if (newTour != null)
            {
                return Ok(newTour);
            }
            return BadRequest("Error");
        }

        [HttpPost]
        public async Task<ActionResult<FindBookedCountDTO?>> BookedCount(FindBookedCountDTO countDTO)
        {
            var count=await _bookingService.BookedCount(countDTO);
            if(count != null) 
                return Ok(count);
            return BadRequest("Error");
        }
    }
}
