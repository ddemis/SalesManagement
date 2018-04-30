using SM.Business.Entities.Districts;
using SM.Business.Entities.SalesMen;
using SM.Business.Entities.Stores;
using SM.DAL.Districts.Mapping;
using SM.DAL.SalesMen.Mapping;
using SM.DAL.Stores.Mapping;
using System.Data.Entity;

namespace SM.DAL
{
    internal class RepositoryContext : DbContext
    {
        public DbSet<District> Districts { get; set; }
        public DbSet<SalesMan> SalesMen { get; set; }
        public DbSet<SalesManDistrict> SalesMenDistricts { get; set; }
        public DbSet<Store> Stores { get; set; }

        public RepositoryContext()
            : base("SalesManagement")
        {
            Database.SetInitializer<RepositoryContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<RepositoryContext>(null);

            modelBuilder.Configurations.Add(new DistrictMapping());
            modelBuilder.Configurations.Add(new SalesManMapping());
            modelBuilder.Configurations.Add(new SalesManDistrictMapping());
            modelBuilder.Configurations.Add(new StoreMapping());
        }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
