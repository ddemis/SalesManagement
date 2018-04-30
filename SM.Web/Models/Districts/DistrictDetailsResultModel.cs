using System.Collections.Generic;

namespace SM.Web.Models.Districts
{
    public class DistrictDetailsResultModel
    {
        public List<DistrictDetailsModel> Districts {get; set;}
        public int TotalNoOfDistricts { get; set; }
    }
}
