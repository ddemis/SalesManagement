using SM.Business.Entities.Districts;
using System.Data.Entity.ModelConfiguration;

namespace SM.DAL.Districts.Mapping
{
    internal class DistrictMapping : EntityTypeConfiguration<District>
    {
        public DistrictMapping()
        {
            ToTable("Districts");
            HasKey(o => o.DistrictId);
        }
    }
}
