using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Services.Districts
{
    public interface IDistrictService
    {
        Task<bool> AddDistrictAsync(District district);
        Task<IList<District>> GetAllDistrictsAsync();
        Task<DistrictDetails> GetDistrictDetailsByIdAsync(int districtId);
    }

}
