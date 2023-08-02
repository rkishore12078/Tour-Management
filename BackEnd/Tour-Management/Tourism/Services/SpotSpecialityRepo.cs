using Microsoft.EntityFrameworkCore;
using Tourism.Interfaces;
using Tourism.Models;

namespace Tourism.Services
{
    public class SpotSpecialityRepo : IRepo<SpotSpeciality, int>
    {
        private readonly dbLocationsContext _context;

        public SpotSpecialityRepo(dbLocationsContext context)
        {
            _context = context;
        }
        public async Task<SpotSpeciality?> Add(SpotSpeciality item)
        {
            try
            {
                if (_context.SpotSpecialities != null)
                {
                    _context.SpotSpecialities.Add(item);
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

        public Task<SpotSpeciality?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SpotSpeciality?> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<SpotSpeciality>?> GetAll()
        {
            try
            {
                if (_context.SpotSpecialities != null)
                {
                    var spotSpecialities = await _context.SpotSpecialities.ToListAsync();
                    if (spotSpecialities != null)
                        return spotSpecialities;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public Task<SpotSpeciality?> Update(SpotSpeciality item)
        {
            throw new NotImplementedException();
        }
    }
}
