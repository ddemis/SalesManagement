using Ninject;
using Ninject.Modules;
using SM.Business.Repository.Districts;
using SM.Business.Repository.SalesMen;
using SM.Business.Repository.Stores;
using SM.Business.Services.Districts;
using SM.Business.Services.SalesMen;
using SM.Business.Services.Stores;
using SM.DAL.Districts;
using SM.DAL.SalesMen;
using SM.DAL.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DIContainer
{
    public class NInjectBindings
    {
        public static void BindDependencies(IKernel kernel)
        {
            kernel.Bind<IDistrictRepository>().To<DistrictRepository>();
            kernel.Bind<IDistrictService>().To<DistrictService>();

            kernel.Bind<ISalesManDistrictRepository>().To<SalesManDistrictRepository>();
            kernel.Bind<ISalesManDistrictService>().To<SalesManDistrictService>();

            kernel.Bind<ISalesManRepository>().To<SalesManRepository>();
            kernel.Bind<ISalesManService>().To<SalesManService>();;

            kernel.Bind<IStoreRepository>().To<StoreRepository>();
            kernel.Bind<IStoreService>().To<StoreService>();
        }
    }
}
