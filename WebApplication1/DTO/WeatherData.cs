using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class WeatherData
    {
        [Required]
        public string Name { get; set; }

        public string Content { get; set; }
    }
}
