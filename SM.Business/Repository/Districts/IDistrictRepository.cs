using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;

namespace SM.Business.Repository.Districts
{
    public interface IDistrictRepository //: IDisposable
    {
        bool AddDistrict(District district);

        DistrictDetailsResult GetDistrictDetails(int startRowNo, int noOfRowsToGet);
    }
}
