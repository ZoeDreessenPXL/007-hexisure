using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Infrastructure.Data
{
    public class InsuranceRepository
    {
        public string _connectionstring;

        public InsuranceRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Add(InsurancePolicy insurance)
        {
            // Vul onderstaande query aan met SqlParameters en voer ze uit.
            
            string query = @"INSERT INTO Insurances (PolicyNumber, CostPerMonth, BasePremium, ClientNumber, Description)
                                VALUES (... TODO ...)";
        }

        public IEnumerable<InsurancePolicy> GetAll()
        {
            throw new NotImplementedException();
        }

        private int GetTotalInsurances()
        {
            throw new NotImplementedException();
        }

        public string GetNextPolicyNumber()
        {
            throw new NotImplementedException();
        }
    }
}
