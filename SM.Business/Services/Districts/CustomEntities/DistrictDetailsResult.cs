using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Business.Services.Districts.CustomEntities
{
    public class DistrictDetailsResult
    {
        public List<DistrictDetails> Districts {get; set;}
        public int TotalNoOfDistricts { get; set; }
    }
}
