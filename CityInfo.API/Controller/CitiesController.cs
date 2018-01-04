using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controller
{
    [Route("api/[controller]")]
    public class CitiesController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new { id=1, Name="New York"},
                new { id=2, Name="Antwerp"},
            });
        }
    }
}
