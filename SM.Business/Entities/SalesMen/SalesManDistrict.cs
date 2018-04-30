using System;
using System.Collections.Generic;
using System.Text;

namespace SM.Business.Entities.SalesMen
{
    [Serializable]
    public class SalesManDistrict
    {
        public int SalesManId { get; set; }
        public int DistrictId { get; set; }
        public int SalesManResponsabilityTypeId { get; set; }
        public SalesManResponsabilityTypes SalesManResponsabilityType
        {
            get { return (SalesManResponsabilityTypes)SalesManResponsabilityTypeId; }
            set { SalesManResponsabilityTypeId = (int)value; }
        }
    }
}
