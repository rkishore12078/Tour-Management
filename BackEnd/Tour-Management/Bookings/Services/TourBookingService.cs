using Bookings.Interfaces;
using Bookings.Models;

namespace Bookings.Services
{
    public class TourBookingService:IBookingService
    {
        private readonly IRepo<TourBooking, int> _tourRepo;

        public TourBookingService(IRepo<TourBooking,int> tourRepo)
        {
            _tourRepo=tourRepo;
        }

        public async Task<TourBooking?> BookTrip(TourBooking tour)
        {
            var newTour = await _tourRepo.Add(tour);
            if (newTour != null)
            {
                return newTour;
            }
            return null;
        }
    }
}
