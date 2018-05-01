
using SM.Api.AutoMapper;
using SM.Api.Models.Districts;
using SM.Business.Services.Districts;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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

        /// <summary>
        /// Get all available districts.
        /// </summary>
        /// <returns>A list containing all districts.</returns>
        [HttpGet]
        public async Task<IList<DistrictModel>> GetAllDistricts()
        {
            
            var districts = await districtService.GetAllDistricts();

            IList<DistrictModel> districtsModel = MapperConfig.Mapper.Map<IList<DistrictModel>>(districts);

            return districtsModel;
        }

        /// <summary>
        /// Get District details by district Id (Stores and associated sales men).
        /// </summary>
        /// <param name="districtId">District Id</param>
        /// <returns>All the stores belonging to a district and the sales men associated with the district.</returns>
        [HttpGet]
        public async Task<DistrictDetailsModel> GetDistrictDetailsById(int districtId)
        {
            //TODO - validate districtId
            var districts = await districtService.GetDistrictDetailsById(districtId);

            DistrictDetailsModel districtDetailsModel = MapperConfig.Mapper.Map<DistrictDetailsModel>(districts);

            throw new HttpResponseException(new HttpResponseMessage { StatusCode = HttpStatusCode.NotFound, ReasonPhrase = "dsfgdgdf"});

            return districtDetailsModel;
        }
    }
}