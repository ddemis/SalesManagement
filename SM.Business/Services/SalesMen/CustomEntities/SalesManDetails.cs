using SM.Business.Entities.SalesMen;

namespace SM.Business.Services.SalesMen.CustomEntities
{
    public class SalesManDetails
    {
        public int SalesManId { get; set; }
        public int SalesUIId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DistrictId { get; set; }
        public SalesManResponsabilityTypes? RepsonsabilityType { get; set; }

    }
}
