using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Model;
public class Search
{
    [Required]
    [StringLength(6, ErrorMessage = "Zone code is of 6 characters", MinimumLength = 6)]
    public string? Criteria { get; set; }
}
