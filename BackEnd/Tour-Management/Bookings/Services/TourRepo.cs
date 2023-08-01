using Bookings.Interfaces;
using Bookings.Models;

namespace Bookings.Services
{
    public class TourRepo : IRepo<TourBooking, int>
    {
        private readonly BookingContext _context;

        public TourRepo(BookingContext context)
        {
            _context=context;
        }
        public async Task<TourBooking?> Add(TourBooking item)
        {
            var transaction = _context.Database.BeginTransaction();
            try
            {
                if (_context.TourBookings == null)
                    return null;
                _context.TourBookings.Add(item);
                await _context.SaveChangesAsync();
                transaction.Commit();
                return item;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw new Exception();
            }
        }

        public Task<TourBooking?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TourBooking?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TourBooking>?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TourBooking?> Update(TourBooking item)
        {
            throw new NotImplementedException();
        }
    }
}
