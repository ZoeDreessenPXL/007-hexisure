using HexiSure.Domain.Entities.Insurables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurances
{
    public class HomeInsurance : InsurancePolicy
    {
        public Residence Home { get; set; }

        public HomeInsurance(int policyNumber, double basePremium, Residence residence) : base(policyNumber, basePremium)
        {
            Home = residence;
        }

        public void AddHomeFireInsurance()
        {
            AddCoverage(new Coverage("Brandverzekering", 100, Home));
        }

        public void AddTheftInsurance10K()
        {
            AddCoverage(new Coverage("Diefstalverzekering", 40));
        }

        public void AddTheftInsurance30K()
        {
            AddCoverage(new Coverage("Diefstalverzekering", 80));
        }

        public override double CalculateTotalPremiumPerMonth()
        {
            return base.CalculateTotalPremiumPerMonth();
        }

        public override string ToString()
        {
            return "Home Insurance: " + base.ToString();
        }
    }
}
