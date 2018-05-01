using SM.Web.Models.SalesMen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Web.Models.Districts
{
    public class DistrictSettingsModel
    {
        public int DistrictId { get; set; }

        public List<SalesManDetailsModel> SalesManDetailsModel { get; set; }
    }
}