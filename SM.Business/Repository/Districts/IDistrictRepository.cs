using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Collections.Generic;

namespace SM.Business.Repository.Districts
{
    public interface IDistrictRepository
    {
        bool AddDistrict(District district);

        IList<District> GetAllDistricts();

        DistrictDetails GetDistrictDetailsByDistrictId(int districtId);
    }
}
