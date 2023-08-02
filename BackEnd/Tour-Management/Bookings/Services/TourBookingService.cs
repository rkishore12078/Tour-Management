using Bookings.Interfaces;
using Bookings.Models;
using Bookings.Models.DTOs;

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
            tour.BookingDate = DateTime.Now;
            var newTour = await _tourRepo.Add(tour);
            if (newTour != null)
            {
                return newTour;
            }
            return null;
        }

        public async Task<FindBookedCountDTO?> BookedCount(FindBookedCountDTO countDTO)
        {
            var bookings=await _tourRepo.GetAll();
            if (bookings != null)
            {
                int count = bookings.Where(b => b.PackageId == countDTO.PackageId && b.DepartureDate .Date== countDTO.TripDate.Date).Sum(b=>b.PeopleCount);
                countDTO.BookedCount = count;
                return countDTO;
            }
            return null;
        }
    }
}
