using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.Weather
{
    public class GetWeatherQueryHandler : ICommandHandler<GetWeatherQuery, IEnumerable<WeatherForecastViewModel>>
    {
        public async Task<IEnumerable<WeatherForecastViewModel>> Handle(GetWeatherQuery request, CancellationToken cancellationToken)
        {
            var weather = Enum.GetNames(typeof(WeatherType)).ToList();
            var rng = new Random();
            var weaderForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecastViewModel
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = weather[rng.Next(weather.Count())]
            })
            .ToList();
            return weaderForecast;
        }
    }
}
