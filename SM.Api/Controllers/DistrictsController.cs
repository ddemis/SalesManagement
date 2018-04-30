
using SM.Api.AutoMapper;
using SM.Api.Models.Districts;
using SM.Business.Services.Districts;
using SM.Business.Services.Districts.CustomEntities;
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
        public DistrictDetailsResultModel GetDistricts(int startRowNo, int noOfRowsToGet)
        {
            //TODO add check for parameters
            var districts = districtService.GetDistrictDetails(startRowNo, noOfRowsToGet);

            DistrictDetailsResultModel districDetailsResultModel = MapperConfig.Mapper.Map<DistrictDetailsResultModel>(districts);

            return districDetailsResultModel;
        }
    }
}