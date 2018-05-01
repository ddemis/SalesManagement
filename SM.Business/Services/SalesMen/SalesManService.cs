using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Services.SalesMen
{
    internal class SalesManService : ISalesManService
    {
        private ISalesManRepository salesManRepository;
        public SalesManService(ISalesManRepository salesManRepository)
        {
            this.salesManRepository = salesManRepository;
        }

        public async Task<IList<SalesManDetails>> GetSalesMenDetailsAsync(int districtId)
        {
            try
            { 
                return await salesManRepository.GetSalesMenDetailsAsync(districtId);
            }
            catch(Exception ex)
            {
                //log
                throw ex;
            }
        }
    }
}
