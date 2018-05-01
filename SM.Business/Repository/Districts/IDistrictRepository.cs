using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Repository.Districts
{
    public interface IDistrictRepository
    {
        Task<bool> AddDistrictAsync(District district);

        Task<IList<District>> GetAllDistrictsAsync();

        Task<DistrictDetails> GetDistrictDetailsByDistrictIdAsync(int districtId);
    }
}
