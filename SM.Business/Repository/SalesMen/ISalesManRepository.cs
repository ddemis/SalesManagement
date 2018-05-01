using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM.Business.Repository.SalesMen
{
    public interface ISalesManRepository
    {
        Task<IList<SalesManDetails>> GetSalesMenDetailsAsync(int districtId);
    }
}
