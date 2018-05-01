using SM.Business.Entities.SalesMen;
using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SM.DAL.SalesMen
{
    internal class SalesManRepository : ISalesManRepository
    {//where salesManDistrict.DistrictId == 1
        public async Task<IList<SalesManDetails>> GetSalesMenDetailsAsync(int districtId)
        {
            IList<SalesManDetails> salesManDetails = new List<SalesManDetails>();
            
            using (var context = new RepositoryContext())
            {
                salesManDetails = await (from salesMan in context.SalesMen
                                        join salesManDistrict in context.SalesMenDistricts on salesMan.SalesManId equals salesManDistrict.SalesManId
                                       
                                        into g
                                        from result in g.Where(f => f.DistrictId == districtId).DefaultIfEmpty()
                                        select new SalesManDetails
                                                {
                                                    SalesManId = salesMan.SalesManId,
                                                    SalesUIId = 0,
                                                    FirstName = salesMan.FirstName,
                                                    LastName = salesMan.LastName,
                                                    DistrictId = result.DistrictId,
                                                    RepsonsabilityType = (SalesManResponsabilityTypes)result.SalesManResponsabilityTypeId
                                                }
                                        ).ToListAsync();
                return salesManDetails;
            }
        }
    }
}
