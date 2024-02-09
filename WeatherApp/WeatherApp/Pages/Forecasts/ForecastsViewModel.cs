using WeatherApp.Model;

namespace WeatherApp.Pages.Forecasts;
public class ForecastsViewModel : IForecastsViewModel
{
    public Forecast firstForecast { get; set; }
    public WeatherForecast? forecast { get; set; }
    public Search search { get; set; } = new();
    public IEnumerable<Zones> zones { get; set; }
    public Zones zone { get; set; }
    public bool fetchError { get; set; } = false;

    public async Task FetchForecast()
    {
        fetchError = false;
        forecast = new WeatherForecast(); // @TODO
        if (forecast.Properties?.Periods is null)
        {
            return;
        }

        firstForecast = forecast.Properties.Periods.Take(1).First();
        forecast.Properties.Periods = forecast.Properties.Periods.Skip(1).ToList();
        zone = zones.FirstOrDefault(z => z.Properties.Id == search.Criteria);
    }

    public async Task FetchZones()
    {
    }
}
