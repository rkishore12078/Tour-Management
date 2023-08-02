using Microsoft.EntityFrameworkCore;
using Tourism.Interfaces;
using Tourism.Models;

namespace Tourism.Services
{
    public class SpotRepo : IRepo<Spot, int>
    {
        private readonly dbLocationsContext _context;

        public SpotRepo(dbLocationsContext context)
        {
            _context = context;
        }
        public async Task<Spot?> Add(Spot item)
        {
            try
            {
                if (_context.Spots != null)
                {
                    _context.Spots.Add(item);
                    await _context.SaveChangesAsync();
                    return item;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public Task<Spot?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Spot?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Spot>?> GetAll()
        {
            try
            {
                if (_context.Spots != null)
                {
                    var spots = await _context.Spots.ToListAsync();
                    if (spots != null)
                        return spots;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public Task<Spot?> Update(Spot item)
        {
            throw new NotImplementedException();
        }
    }
}
