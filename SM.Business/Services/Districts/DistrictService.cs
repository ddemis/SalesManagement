using SM.Business.Entities.Districts;
using SM.Business.Repository.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Business.Services.Districts
{
    internal class DistrictService : IDistrictService
    {
        private IDistrictRepository districtRepository;
        public DistrictService(IDistrictRepository districtRepository)
        {
            this.districtRepository = districtRepository;
        }

        public async Task<bool> AddDistrict(District district)
        {
            return await districtRepository.AddDistrict(district);
        }

        public async Task<IList<District>> GetAllDistricts()
        {
            return await districtRepository.GetAllDistricts();
        }

        public async Task<DistrictDetails> GetDistrictDetailsById(int districtId)
        {
            return await districtRepository.GetDistrictDetailsByDistrictId(districtId);
        }
    }
}
