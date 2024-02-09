using WeatherApp.Model;

namespace WeatherApp.Pages.Forecasts;
public interface IForecastsViewModel
{
    Forecast firstForecast { get; set; }
    WeatherForecast forecast { get; set; }
    Search search { get; set; }
    public IEnumerable<Zones> zones { get; set; }
    public Zones zone { get; set; }
    bool fetchError { get; set; }

    Task FetchForecast();
    Task FetchZones();
}
