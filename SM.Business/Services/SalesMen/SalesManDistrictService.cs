using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Business.Services.SalesMen
{
    public interface ISalesManDistrictService
    {
        Task<bool> AddUpdateSalesManDistrictAndResponsability(IList<SalesManDetails> salesMenDetails);
    }
    internal class SalesManDistrictService : ISalesManDistrictService
    {
        private ISalesManDistrictRepository salesManDistrictRepository;
        public SalesManDistrictService(ISalesManDistrictRepository salesManDistrictRepository)
        {
            this.salesManDistrictRepository = salesManDistrictRepository;
        }

        public async Task<bool> AddUpdateSalesManDistrictAndResponsability(IList<SalesManDetails> salesMenDetails)
        {
            var salesMenAssociatedWithADistrict = salesMenDetails.Where(o => o.DistrictId != null).ToList();
            //TODO - filter sales men care nu sunt asociati cu un district, nu are rost sa mergem cu ei la db
            return await salesManDistrictRepository.AddUpdateSalesManDistrictAndResponsability(salesMenAssociatedWithADistrict);
        }
    }
}
