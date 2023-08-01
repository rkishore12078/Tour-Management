using Bookings.Models;

namespace Bookings.Interfaces
{
    public interface IBookingService
    {
        public Task<TourBooking?> BookTrip(TourBooking tour);
    }
}
