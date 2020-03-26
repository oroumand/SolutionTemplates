﻿using OnionArchitecture.Core.Domain.WeatherForecasts.Entities;
using OnionArchitecture.Core.Domain.WeatherForecasts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitecture.Core.ApplicationServices.WeatherForecasts
{
    public class RandomForecastsGenerator : IRandomForecastsGenerator
    {
        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public List<WeatherForecast> Execute()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }
    }
}
