using SM.Business.Entities.Stores;
using System.Data.Entity.ModelConfiguration;

namespace SM.DAL.Stores.Mapping
{
    internal class StoreMapping : EntityTypeConfiguration<Store>
    {
        public StoreMapping()
        {
            ToTable("Stores");
            HasKey(o => o.StoreId);
        }
    }
}