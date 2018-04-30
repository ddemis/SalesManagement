using SM.Business.Entities.SalesMen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Business.Services.Districts.CustomEntities
{
    public class SalesManDetails
    {
        public int SalesManId { get; set; }
        public int SalesUIId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SalesManResponsabilityTypes RepsonsabilityType { get; set; }

    }
}
