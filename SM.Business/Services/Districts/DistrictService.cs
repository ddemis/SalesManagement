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
    public interface IDistrictService
    {
        bool AddDistrictService(District district);
        DistrictDetailsResult GetDistrictDetails(int startRowNo, int noOfRowsToGet);
    }

    internal class DistrictService : IDistrictService
    {
        private IDistrictRepository districtRepository;
        public DistrictService(IDistrictRepository districtRepository)
        {
            this.districtRepository = districtRepository;
        }

        public bool AddDistrictService(District district)
        {
            return districtRepository.AddDistrict(district);
        }

        public DistrictDetailsResult GetDistrictDetails(int startRowNo, int noOfRowsToGet)
        {
            return districtRepository.GetDistrictDetails(startRowNo, noOfRowsToGet);
        }
    }
}
