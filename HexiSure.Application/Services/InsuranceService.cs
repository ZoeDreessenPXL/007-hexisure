using HexiSure.Domain.Entities.Insurables;
using HexiSure.Domain.Entities.Insurances;
using HexiSure.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Application.Services
{
    public class InsuranceService
    {
        private InsuranceRepository _insuranceRepository;

        public InsuranceService(InsuranceRepository repository)
        {
            _insuranceRepository = repository;
        }

        public List<InsurancePolicy> GetAllInsurances()
        {
            return _insuranceRepository.GetAll().ToList();
        }

        public void AddInsurance(InsurancePolicy insurance)
        {
            _insuranceRepository.Add(insurance);
        }

        public List<Municipality> GetAllMunicipality()
        {
            MunicipalityData.RetrieveMunicipalities();
            return MunicipalityData.Municipalities;
        }
    }
}
