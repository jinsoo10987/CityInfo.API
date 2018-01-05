using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        //Make immutable
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //dummy data
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1, Name = "New York", Description = "Central Park"
                },
                new CityDto {
                    Id = 2, Name = "Houston", Description = "NASA",
                    PointsOfInterests = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto { Id = 1, Name = "Memorial Park", Description = "Good"},
                        new PointOfInterestDto { Id = 2, Name = "H-Mart", Description = "Asian food"},
                    }},
                new CityDto { Id = 3, Name = "Seoul", Description = "Ton of fun!!"}
            };
        }
    }
}
