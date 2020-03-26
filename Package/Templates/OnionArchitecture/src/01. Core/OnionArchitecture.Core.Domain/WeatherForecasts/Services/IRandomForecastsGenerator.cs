using OnionArchitecture.Core.Domain.WeatherForecasts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Core.Domain.WeatherForecasts.Services
{
    public interface IRandomForecastsGenerator
    {
        List<WeatherForecast> Execute();
    }
}
