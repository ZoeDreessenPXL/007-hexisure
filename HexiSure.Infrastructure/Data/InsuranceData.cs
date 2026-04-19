using HexiSureClassLibrary.Entities.Insurances;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSureClassLibrary.DataAccess
{
    public class InsuranceData
    {
        public static string ConnectionString { get; set; }

        public static void InsertNewInsurance(InsurancePolicy insurance)
        {
            // Vul onderstaande query aan met SqlParameters en voer ze uit.
            
            string query = @"INSERT INTO Insurances (PolicyNumber, CostPerMonth, BasePremium, ClientNumber, Description)
                                VALUES (... TODO ...)";
        }

        public static DataView SelectAllInsurances()
        {
            throw new NotImplementedException();
        }

        private static int GetTotalInsurances()
        {
            throw new NotImplementedException();
        }

        public static string GetNextPolicyNumber()
        {
            throw new NotImplementedException();
        }
    }
}
