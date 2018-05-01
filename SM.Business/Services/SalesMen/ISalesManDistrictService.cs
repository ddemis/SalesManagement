using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Services.SalesMen
{
    public interface ISalesManDistrictService
    {
        Task<bool> AddUpdateSalesManDistrictAndResponsability(IList<SalesManDetails> salesMenDetails);
    }
}
