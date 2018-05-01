using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Repository.SalesMen
{
    public interface ISalesManDistrictRepository
    {
        Task<bool> AddUpdateSalesManDistrictAndResponsability(IList<SalesManDetails> salesMenDetails);
    }
}
