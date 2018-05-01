using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Business.Services.SalesMen
{
    internal class SalesManDistrictService : ISalesManDistrictService
    {
        private ISalesManDistrictRepository salesManDistrictRepository;
        public SalesManDistrictService(ISalesManDistrictRepository salesManDistrictRepository)
        {
            this.salesManDistrictRepository = salesManDistrictRepository;
        }

        public async Task<bool> AddUpdateSalesManDistrictAndResponsabilityAsync(IList<SalesManDetails> salesMenDetails)
        {
            try
            {
                //filter sales men that are not associated with a district
                var salesMenAssociatedWithADistrict = salesMenDetails.Where(o => o.DistrictId != null).ToList();

                return await salesManDistrictRepository.AddUpdateSalesManDistrictAndResponsabilityAsync(salesMenAssociatedWithADistrict);
            }
            catch(Exception ex)
            {
                //log ex
                throw ex;
            }
        }
    }
}
