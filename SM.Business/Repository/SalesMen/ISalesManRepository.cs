using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;

namespace SM.Business.Repository.SalesMen
{
    public interface ISalesManRepository
    {
        IList<SalesManDetails> GetSalesMenDetails();
    }
}
