using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAsm.Models
{
    public class WeatherInfo
    {
        public string product { get; set; }
        public double init { get; set; }

        public DataSeries DataSeries { get; set; }
    }
}
