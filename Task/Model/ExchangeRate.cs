using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class ExchangeRate
    {
        public DateTime BusinesDay { get; set; }
        public double EuroRate { get; set; } = 1.0;
        public double USDrate { get; set; }
        public double INRrate { get; set; }
        // Add properties for other currencies as needed
    }
}
