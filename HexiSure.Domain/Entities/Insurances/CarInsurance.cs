using HexiSure.Domain.Entities.Insurables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurances
{
    public class CarInsurance : InsurancePolicy
    {
        public Car Car { get; set; }

        public CarInsurance(int policyNumber, double basePremium, Car car) : base(policyNumber, basePremium)
        {
            Car = car;
        }

        public void AddOmnium()
        {
            AddCoverage(new Coverage("Omnium", 95, Car));
        }

        public override string ToString()
        {
            return "Car Insurance: " + base.ToString();
        }
    }
}
