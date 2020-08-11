namespace WebApplication1
{
    public class WeatherEvent
    {
        public int WeatherEventId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
