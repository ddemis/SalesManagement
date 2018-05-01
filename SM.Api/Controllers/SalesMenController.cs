using SM.Api.AutoMapper;
using SM.Api.Models.SalesMen;
using SM.Business.Services.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace SM.Api.Controllers
{
    public class SalesMenController : ApiController
    {
        private ISalesManService salesManService;
        private ISalesManDistrictService salesManDistrictService;
        public SalesMenController(ISalesManService salesManService, ISalesManDistrictService salesManDistrictService)
        {
            this.salesManService = salesManService;
            this.salesManDistrictService = salesManDistrictService;
        }

        /// <summary>
        /// Get all sales men with details about belonging districts.
        /// </summary>
        /// <returns>A list of sales man details, belonging district and responsability type.</returns>
        [HttpGet]
        public async Task<IList<SalesManDetailsModel>> GetSalesMenDetails()
        {
            var districts = await salesManService.GetSalesMenDetails();

            IList<SalesManDetailsModel> salesManDetailsModel = MapperConfig.Mapper.Map<IList<SalesManDetailsModel>>(districts);

            return salesManDetailsModel;
        }

        [HttpPost]
        public async Task<bool> UpdateSalesManDistrictAndResponsability(IList<SalesManDetailsModel> salesMenDetailsModel)
        {
            //TODO
            //if (!ModelState.IsValid)
            //  return BadRequest(ModelState);

            IList<SalesManDetails> salesManDetails = MapperConfig.Mapper.Map<IList<SalesManDetails>>(salesMenDetailsModel);


            var result = await salesManDistrictService.AddUpdateSalesManDistrictAndResponsability(salesManDetails);
            return result;
        }
    }
}