using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Repository.SalesMen
{
    public interface ISalesManDistrictRepository
    {
        Task<bool> AddUpdateSalesManDistrictAndResponsabilityAsync(IList<SalesManDetails> salesMenDetails);
    }
}
