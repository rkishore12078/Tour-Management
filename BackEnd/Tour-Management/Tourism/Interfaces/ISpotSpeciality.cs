using Tourism.Models;

namespace Tourism.Interfaces
{
    public interface ISpotSpeciality
    {
        public Task<List<SpotSpeciality>?> AddSpotSpeciality(List<SpotSpeciality> spotSpecialities);
    }
}
