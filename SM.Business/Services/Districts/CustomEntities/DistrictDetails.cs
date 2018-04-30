using SM.Business.Entities.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Business.Services.Districts.CustomEntities
{
    public class DistrictDetails
    {
        public int DistrictId { get; set; }
        //public string DistrictName { get; set; }
        
        public List<Store> Stores { get; set; }
        public List<SalesManDetails> SalesMenDetails { get; set; }
    }
}
