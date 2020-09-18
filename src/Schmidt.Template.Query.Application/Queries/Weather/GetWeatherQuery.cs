using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;

namespace Schmidt.Template.Query.Application.Queries.Weather
{
    public class GetWeatherQuery : ICommand<IEnumerable<WeatherForecastViewModel>>
    {
    }
}
