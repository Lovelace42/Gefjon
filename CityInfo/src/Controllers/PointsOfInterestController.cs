using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityApp.API.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            // Find City
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{pointId}")]
        public IActionResult GetPointOfInterest(int cityId, int pointId)
        {
            // Find City
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            // Find Point of Interest
            var pointToReturn = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointId);
            if (pointToReturn == null)
            {
                return NotFound();
            }

            return Ok(pointToReturn);
        }
    }
}
