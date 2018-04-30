using AutoMapper;
using SM.Api.AutoMapper;
using SM.Api.Models.Districts;
using SM.Api.Models.Stores;
using SM.Business.Entities.Stores;
using SM.Business.Services.Districts.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Api.App_Start
{
    public class AutoMapperConfig
    {
        public static void ConfigureAutoMapper()
        {
            Action<IMapperConfigurationExpression> configuration = cfg =>
            {
                cfg.CreateMap<DistrictDetails, DistrictDetailsModel>();
                cfg.CreateMap<DistrictDetailsResult, DistrictDetailsResultModel>();
                cfg.CreateMap<SalesManDetails, SalesManDetailsModel>();
                cfg.CreateMap<Store, StoreModel>();
            };

            MapperConfig.InitAutoMapper(configuration);
        }
    }
}