using SM.Api.Models.SalesMen;
using SM.Api.Models.Stores;
using System.Collections.Generic;

namespace SM.Api.Models.Districts
{
    public class DistrictDetailsModel
    {
        public int DistrictId { get; set; }     
        public List<StoreModel> Stores { get; set; }
        public List<SalesManDetailsModel> SalesMenDetails { get; set; }
    }
}
