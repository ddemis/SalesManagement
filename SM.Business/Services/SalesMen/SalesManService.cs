using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
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

        public async Task<IList<SalesManDetails>> GetSalesMenDetails()
        {
            return await salesManRepository.GetSalesMenDetails();
        }
    }
}
