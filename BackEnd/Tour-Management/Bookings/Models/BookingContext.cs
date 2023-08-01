using Microsoft.EntityFrameworkCore;

namespace Bookings.Models
{
    public class BookingContext:DbContext
    {
        public BookingContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<TourBooking>? TourBookings { get; set; }
        public DbSet<BookedHotels>? BookedHotels { get; set; }
        public DbSet<People>? People { get; set; }
    }
}
