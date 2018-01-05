namespace CityInfo.API.Models
{
    //TODO consider base/abstract class that has id or some common properties
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}