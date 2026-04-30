using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurables
{
    public class Residence : IInsurable
    {
        public string[] PossibleTypes = ["Open", "Half open", "Gesloten", "Appartement"];
        private string _type;

        public string Type
        {
            get { return _type; }
            set 
            {
                if (!PossibleTypes.Contains(value))
                {
                    throw new ArgumentException("Ongeldig type");
                }

                _type = value;
            }
        }

        public string Address { get; set; }
        public DateTime DateBuilt { get; set; }
        public double LivingArea { get; set; }
        public double MarketValue { get; set; }
        public Municipality Municipality { get; set; }


        public Residence(string address, Municipality municipality, string type, 
            DateTime dateBuilt, double livingArea, double marketValue)
        {
            Address = address;
            DateBuilt = dateBuilt;
            LivingArea = livingArea;
            MarketValue = marketValue;
            Municipality = municipality;
            Type = type;
        }

        public double CalculateCoverageModifier()
        {
            int age = (int)(DateTime.Now - DateBuilt).TotalDays / 365;
            double ageFactor = 1 - Math.Min(age / 50.0, 0.5);
            double sizeFactor = Math.Max(Math.Min(LivingArea / 100.0, 2.0), 0.7);
            double valueFactor = Math.Min(Math.Max(MarketValue / 250000, 0.7), 3.0);
            return ageFactor * sizeFactor * valueFactor;
        }
    }
}
