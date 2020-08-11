using System.Collections.Generic;

namespace WebApplication1
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }

        public List<WeatherEvent> Events { get; } = new List<WeatherEvent>();
    }
}
