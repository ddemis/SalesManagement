using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Services.SalesMen
{
    public interface ISalesManService
    {
        Task<IList<SalesManDetails>> GetSalesMenDetails();
    }
}
