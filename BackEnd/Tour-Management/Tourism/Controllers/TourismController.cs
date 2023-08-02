using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Interfaces;
using Tourism.Models;
using Tourism.Models.DTOs;
using Tourism.Services;

namespace Tourism.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("ReactCors")]
    public class TourismController : ControllerBase
    {
        private readonly IimageService _imageService;
        private readonly ISpotSpeciality _spotSpecialityService;
        private readonly ISpotService _spotService;

        public TourismController(ISpotService spotService,
                                 ISpotSpeciality spotSpecialityService,
                                 IimageService imageService)
        {
            _imageService=imageService;
            _spotSpecialityService=spotSpecialityService;
            _spotService=spotService;
        }
        [HttpPost]
        public async Task<ActionResult<Spot?>> AddSpot(Spot spot)
        {
            var newSpot=await _spotService.AddSpot(spot);
            if (newSpot != null)
                return Ok(newSpot);
            return BadRequest("Error");
        }
        [HttpPost]
        public async Task<ActionResult<List<SpotSpeciality>?>> AddSpotSpecialities(List<SpotSpeciality> spotSpecialities)
        {
            var newSpotSpecialities = await _spotSpecialityService.AddSpotSpeciality(spotSpecialities);
            if (newSpotSpecialities != null)
                return Ok(newSpotSpecialities);
            return BadRequest("Error");
        }
        [HttpPost]
        public async Task<ActionResult<List<Image>?>> AddImage(List<Image> images)
        {
            var newImages = await _imageService.AddImage(images);
            if (newImages != null)
                return Ok(newImages);
            return BadRequest("Error");
        }
        [HttpPost]
        public async Task<ActionResult<Spot?>> AddSpeciality(Speciality speciality)
        {
            var newSpeciality = await _spotService.AddSpeciality(speciality);
            if (newSpeciality != null)
                return Ok(newSpeciality);
            return BadRequest("Error");
        }
        [HttpGet]
        public async Task<ActionResult<List<CountryDTO>?>> GetAllCountries()
        {
            var countries=await _spotService.GetAllCountries();
            if(countries != null)
                return Ok(countries);
            return BadRequest("Error");
        }
        [HttpGet]
        public async Task<ActionResult<List<Spot>?>> GetAllSpots()
        {
            var spots = await _spotService.GetAllSpot();
            if (spots != null)
                return Ok(spots);
            return BadRequest("Error");
        }

        [HttpPost]
        public async Task<ActionResult<List<StateDTO>?>> GetStateByCountry(IdDTO idDTO)
        {
            var states = await _spotService.GetAllStates(idDTO);
            if (states != null)
                return Ok(states);
            return BadRequest("Error");
        }

        [HttpPost]
        public async Task<ActionResult<List<City>?>> GetCityByState(IdDTO idDTO)
        {
            var cities = await _spotService.GetAllCity(idDTO);
            if(cities != null)
                return Ok(cities);
            return BadRequest("Error");
        }

        [HttpPost]
        public async Task<ActionResult<List<Spot>?>> GetSpotByCity(IdDTO idDTO)
        {
            var spots = await _spotService.SpotByCity(idDTO);
            if (spots != null)
                return Ok(spots);
            return BadRequest("Error");
        }
    }
}
