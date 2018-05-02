using SM.Business.Repository.Districts;
using System;
using System.Collections.Generic;
using System.Text;
using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Linq;
using SM.Business.Entities.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SM.DAL.Districts
{
    internal class DistrictRepository : IDistrictRepository
    {
        public async Task<bool> AddDistrictAsync(District district)
        {
            using (var context = new RepositoryContext())
            {
                context.Districts.Add(district);
                int result = await context.SaveChangesAsync();
                return result == 1;
            }            
        }

        public async Task<IList<District>> GetAllDistrictsAsync()
        {            
            using (var context = new RepositoryContext())
            {
                return await context.Districts.ToListAsync();
            }
        }

        public async Task<DistrictDetails> GetDistrictDetailsByDistrictIdAsync(int districtId)
        {
            DistrictDetails districtDetails = new DistrictDetails();
            using (var context = new RepositoryContext())
            {
                if (context.Districts.Any(o => o.DistrictId == districtId))
                {
                    districtDetails.DistrictId = districtId;
                    districtDetails.Stores = context.Stores.Where(o => o.DistrictId == districtId).ToList();
                    districtDetails.SalesMenDetails = await (from salesMan in context.SalesMen
                                                             join salesManDistrict in context.SalesMenDistricts on salesMan.SalesManId equals salesManDistrict.SalesManId
                                                             where salesManDistrict.DistrictId == districtId
                                                             select new SalesManDetails
                                                             {
                                                                 SalesManId = salesMan.SalesManId,
                                                                 SalesUIId = 0,
                                                                 FirstName = salesMan.FirstName,
                                                                 LastName = salesMan.LastName,
                                                                 RepsonsabilityType = (SalesManResponsabilityTypes)salesManDistrict.SalesManResponsabilityTypeId
                                                             }).ToListAsync();
                }                
            }
            return districtDetails;
        }
    }
}
