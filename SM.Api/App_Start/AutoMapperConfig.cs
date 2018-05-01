using AutoMapper;
using SM.Api.AutoMapper;
using SM.Api.Models.Districts;
using SM.Api.Models.SalesMen;
using SM.Api.Models.Stores;
using SM.Business.Entities.Districts;
using SM.Business.Entities.Stores;
using SM.Business.Services.Districts.CustomEntities;
using SM.Business.Services.SalesMen.CustomEntities;
using System;

namespace SM.Api.App_Start
{
    public class AutoMapperConfig
    {
        public static void ConfigureAutoMapper()
        {
            Action<IMapperConfigurationExpression> configuration = cfg =>
            {
                cfg.CreateMap<District, DistrictModel>();
                cfg.CreateMap<DistrictDetails, DistrictDetailsModel>();
                cfg.CreateMap<DistrictDetailsResult, DistrictDetailsResultModel>();
                cfg.CreateMap<SalesManDetails, SalesManDetailsModel>();
                cfg.CreateMap<Store, StoreModel>();
            };

            MapperConfig.InitAutoMapper(configuration);
        }
    }
}