using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Tourism.Models
{
    public class SpotSpeciality
    {
        public int SpotSpecialityId { get; set; }
        public int SpotId { get; set; }
        [ForeignKey("SpotId")]
        [JsonIgnore]
        public Spot? Spots { get; set; }
        public int SpecialityId { get; set; }
        [ForeignKey("SpecialityId")]
        [JsonIgnore]
        public Speciality? Specialities { get; set; }
    }
}
