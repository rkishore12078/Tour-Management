using Bookings.Interfaces;
using Bookings.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookings.Controllers
{
    [Route("api/[controller]")]
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
    }
}
