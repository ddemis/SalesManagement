
using SM.Api.AutoMapper;
using SM.Api.Models.Districts;
using SM.Business.Services.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Collections.Generic;
using System.Web.Http;

namespace SM.Api.Controllers
{
    public class DistrictsController : ApiController
    {
        IDistrictService districtService;
        public DistrictsController(IDistrictService districtService)
        {
            this.districtService = districtService;
        }

        [HttpGet]
        public IList<DistrictModel> GetAllDistricts()
        {
            
            var districts = districtService.GetAllDistricts();

            IList<DistrictModel> districtsModel = MapperConfig.Mapper.Map<IList<DistrictModel>>(districts);

            return districtsModel;
        }

        [HttpGet]
        public DistrictDetailsModel GetDistrictDetailsById(int districtId)
        {
            var districts = districtService.GetDistrictDetailsById(districtId);

            DistrictDetailsModel districtDetailsModel = MapperConfig.Mapper.Map<DistrictDetailsModel>(districts);

            return districtDetailsModel;
        }

        //[HttpGet]
        //public DistrictDetailsResultModel GetDistricts(int startRowNo, int noOfRowsToGet)
        //{
        //    //TODO add check for parameters
        //    var districts = districtService.GetDistrictDetails(startRowNo, noOfRowsToGet);

        //    DistrictDetailsResultModel districDetailsResultModel = MapperConfig.Mapper.Map<DistrictDetailsResultModel>(districts);

        //    return districDetailsResultModel;
        //}
    }
}