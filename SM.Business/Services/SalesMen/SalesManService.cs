using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;

namespace SM.Business.Services.SalesMen
{
    public interface ISalesManService
    {
        IList<SalesManDetails> GetSalesMenDetails();
    }
    internal class SalesManService : ISalesManService
    {
        private ISalesManRepository salesManRepository;
        public SalesManService(ISalesManRepository salesManRepository)
        {
            this.salesManRepository = salesManRepository;
        }

        public IList<SalesManDetails> GetSalesMenDetails()
        {
            return salesManRepository.GetSalesMenDetails();
        }
    }
}
