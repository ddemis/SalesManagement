using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Api.AutoMapper
{
    public class MapperConfig
    {
        private static MapperConfiguration MapperConfiguration;
        public static IMapper Mapper;

        public static void InitAutoMapper(Action<IMapperConfigurationExpression> mapperConfig)
        {
            MapperConfiguration = new MapperConfiguration(mapperConfig);
            Mapper = MapperConfiguration.CreateMapper();

        }
    }
}