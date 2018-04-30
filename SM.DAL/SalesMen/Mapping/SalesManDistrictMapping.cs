using SM.Business.Entities.SalesMen;
using System.Data.Entity.ModelConfiguration;

namespace SM.DAL.SalesMen.Mapping
{
    internal class SalesManDistrictMapping : EntityTypeConfiguration<Business.Entities.SalesMen.SalesManDistrict>
    {
        public SalesManDistrictMapping()
        {
            ToTable("SalesMen_Districts");
            HasKey(o => new { o.SalesManId, o.DistrictId });
            Ignore(o => o.SalesManResponsabilityType);
        }
    }
}