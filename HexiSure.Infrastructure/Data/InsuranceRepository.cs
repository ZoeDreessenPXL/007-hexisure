using Dapper;
using HexiSure.Domain.Entities.Insurances;
using Microsoft.Data.SqlClient;
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
            using(SqlConnection conn =  new SqlConnection(_connectionstring))
            {
                string query = @"INSERT INTO Insurances (PolicyNumber, CostPerMonth, BasePremium, ClientNumber, Description)
                                VALUES (@PolicyNumber, @CostPerMonth, @BasePremium, @ClientNumber, @Description)";
                conn.Execute(query, new { PolicyNumber = GetNextPolicyNumber(), CostPerMonth = insurance.CalculateTotalPremiumPerMonth(), 
                    BasePremium = insurance.BasePremium, ClientNumber = insurance.ClientNumber, Description = insurance.ToString()});
            }
        }

        public IEnumerable<InsurancePolicy> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string sql = @"SELECT * FROM Insurances";
                return conn.Query<InsurancePolicy>(sql);
            }
        }

        private int GetTotalInsurances()
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string todayPrefix = DateTime.Now.ToString("yyMMdd");

                string sql = @"
                    SELECT COUNT(*) 
                    FROM Insurances
                    WHERE CAST(PolicyNumber AS VARCHAR(20)) LIKE @prefix + '%'";

                return conn.ExecuteScalar<int>(sql, new { prefix = todayPrefix });
            }
        }

        public int GetNextPolicyNumber()
        {
            string todayPrefix = DateTime.Now.ToString("yyMMdd");

            int count = GetTotalInsurances();

            string sequence = count.ToString("D3");

            string result = $"{todayPrefix}{sequence}";

            return int.Parse(result);
        }
    }
}
