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

        public async Task<bool> AddDistrictAsync(District district)
        {
            try
            {
                return await districtRepository.AddDistrictAsync(district);
            }
            catch(Exception ex)
            {
                //log exception
                throw ex;
            }
            
        }

        public async Task<IList<District>> GetAllDistrictsAsync()
        {
            try
            {
                return await districtRepository.GetAllDistrictsAsync();
            }
            catch(Exception ex)
            {
                //log exception
                throw ex;
            }
        }

        public async Task<DistrictDetails> GetDistrictDetailsByIdAsync(int districtId)
        {
            try
            {
                return await districtRepository.GetDistrictDetailsByDistrictIdAsync(districtId);
            }
            catch(Exception ex)
            {
                //log exception
                throw ex;
            }
        }
    }
}
