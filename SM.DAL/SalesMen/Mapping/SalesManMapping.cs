using SM.Business.Entities.SalesMen;
using System.Data.Entity.ModelConfiguration;

namespace SM.DAL.SalesMen.Mapping
{
    internal class SalesManMapping : EntityTypeConfiguration<SalesMan>
    {
        public SalesManMapping()
        {
            ToTable("SalesMen");
            HasKey(o => o.SalesManId);
        }
    }
}