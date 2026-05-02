using HexiSure.Domain.Entities.Insurables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurances
{
    public class Coverage
    {
        public IInsurable InsuredObject { get; set; }
        public string Name { get; set; }
        private double _baseCostPerMonth;

        public double CostPerMonth
        {
            get
            {
                if (InsuredObject == null)
                    return _baseCostPerMonth;

                return _baseCostPerMonth * InsuredObject.CalculateCoverageModifier();
            }
        }

        public Coverage(string name, double baseCostPerMonth)
        {
            Name = name;
            _baseCostPerMonth = baseCostPerMonth;
        }

        public Coverage(string name, double baseCostPerMonth, IInsurable insuredObject)
            : this(name, baseCostPerMonth)
        {
            InsuredObject = insuredObject;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
