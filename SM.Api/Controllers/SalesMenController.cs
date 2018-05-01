using SM.Api.AutoMapper;
using SM.Api.Models.SalesMen;
using SM.Api.Validators;
using SM.Business.Services.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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
        public async Task<IList<SalesManDetailsModel>> GetSalesMenDetails(int districtId)
        {
            try
            {
                var districts = await salesManService.GetSalesMenDetailsAsync(districtId);

                IList<SalesManDetailsModel> salesManDetailsModel = MapperConfig.Mapper.Map<IList<SalesManDetailsModel>>(districts);

                return salesManDetailsModel;
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(resp);
            }
        }

        /// <summary>
        /// Save sales men belonging to a district and their responsability.
        /// </summary>
        /// <param name="salesMenDetailsModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> UpdateSalesManDistrictAndResponsability(IList<SalesManDetailsModel> salesMenDetailsModel)
        {
            
            if (!InputDataValidator.ValidateSalesMenDistrictRelation(salesMenDetailsModel))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("The District must have a primary responsable sales man.")
                };
                throw new HttpResponseException(resp);
            }

            try
            {
                IList<SalesManDetails> salesManDetails = MapperConfig.Mapper.Map<IList<SalesManDetails>>(salesMenDetailsModel);
                
                var result = await salesManDistrictService.AddUpdateSalesManDistrictAndResponsabilityAsync(salesManDetails);
                return result;
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(resp);
            }
        }
    }
}