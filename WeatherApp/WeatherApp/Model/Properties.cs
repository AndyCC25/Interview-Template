namespace WeatherApp.Model;
public class Properties
{
    public string? Zone { get; set; }

    public DateTime Updated { get; set; }

    public List<Forecast>? Periods { get; set; }
}
