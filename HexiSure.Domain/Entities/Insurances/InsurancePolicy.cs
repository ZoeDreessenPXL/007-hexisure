using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurances
{
    public abstract class InsurancePolicy
    {
        public double BasePremium { get; set; }
        public int ClientNumber { get; set; } = 0;
        public int PolicyNumber { get; set; }
        private List<Coverage> _coverages;

        public List<Coverage> Coverages
        {
            get { return _coverages; }
        }

        protected InsurancePolicy(int policyNumber, double basePremium)
        {
            PolicyNumber = policyNumber;
            BasePremium = basePremium;
            _coverages = new List<Coverage>();
        }

        public void AddCivilLiability()
        {
            AddCoverage(new Coverage("Burgelijke aansprakelijkheid", 10));
        }

        public void AddCoverage(Coverage coverage)
        {
            if (!_coverages.Any(c => c.Name == coverage.Name))
            {
                _coverages.Add(coverage);
            }
        }

        public void AddLegalAid()
        {
            AddCoverage(new Coverage("Rechtsbijstand", 20));
        }

        public virtual double CalculateTotalPremiumPerMonth()
        {
            double total = 0;

            foreach(Coverage coverage in _coverages)
            {
                total += coverage.CostPerMonth;
            }

            return total;
        }

        public void RemoveCoverage(Coverage coverage)
        {
            _coverages.Remove(coverage);
        }

        public override string ToString()
        {
            return string.Join(", ", _coverages.Select(c => c.Name));
        }
    }
}
