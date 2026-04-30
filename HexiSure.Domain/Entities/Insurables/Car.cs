using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurables
{
    public class Car : IInsurable
    {
        public string Brand { get; set; }
        public DateTime DateBuilt { get; set; }
        public double InitialPrice { get; set; }
        public int KmPerYear { get; set; }
        public string LicensePlate { get; set; }
        public int Power { get; set; }

        public double CalculateCoverageModifier()
        {
            return InitialPrice / 10000.0 * (KmPerYear / 10000.0) * (Power / 120.0) * (1 - ((DateTime.Now - DateBuilt).Days / 365.0) / 50);
        }
    }
}
