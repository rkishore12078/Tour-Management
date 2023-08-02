using Tourism.Interfaces;
using Tourism.Models;

namespace Tourism.Services
{
    public class SpotSpecialityService:ISpotSpeciality
    {
        private readonly IRepo<SpotSpeciality, int> _spotSpecialityRepo;

        public SpotSpecialityService(IRepo<SpotSpeciality,int> spotSpecialityRepo)
        {
            _spotSpecialityRepo=spotSpecialityRepo;
        }
        public async Task<List<SpotSpeciality>?> AddSpotSpeciality(List<SpotSpeciality> spotSpecialities)
        {
            for (int i = 0; i < spotSpecialities.Count; i++)
            {
                var spotSpeciality=await _spotSpecialityRepo.Add(spotSpecialities[i]);
                if (spotSpeciality == null)
                    return null;
            }
            return spotSpecialities;
        }
    }
}
