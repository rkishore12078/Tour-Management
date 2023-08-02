using Bookings.Models;
using Bookings.Models.DTOs;

namespace Bookings.Interfaces
{
    public interface IBookingService
    {
        public Task<TourBooking?> BookTrip(TourBooking tour);
        public Task<FindBookedCountDTO?> BookedCount(FindBookedCountDTO countDTO);
    }
}
