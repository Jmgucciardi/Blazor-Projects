using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAsm.Models
{
    public class DataSeries
    {
        public int TimePoint { get; set; }
        public int CloudCover { get; set; }
        public int Seeing { get; set; }
        public int Transpaency { get; set; }
        public int Lifted_Index { get; set; }
        public int Rh2m { get; set; }
        public int Temp2m { get; set; }
        public string Prec_Type { get; set; }
        
        public Wind10m Wind10M { get; set; }
    }
}
