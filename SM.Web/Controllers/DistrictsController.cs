using SM.Web.Models.Districts;
using SM.Web.Models.SalesMen;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class DistrictsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {  
            IList<DistrictModel> districtstModel = await GetAsync<IList<DistrictModel>>("Districts/GetAllDistricts");
            return View(districtstModel);
        }

        [HttpGet]
        public async Task<ActionResult> Details(int districtId)
        {
            DistrictDetailsModel districtDetailsModel = await GetAsync<DistrictDetailsModel>($"Districts/GetDistrictDetailsById?districtId={districtId}");
            return View(viewName: "Details", model: districtDetailsModel);
        }

        [HttpGet]
        public async Task<ActionResult> Settings(int districtId)
        {
            var salesManDetailsModel = await GetAsync<List<SalesManDetailsModel>>($"SalesMen/GetSalesMenDetails?districtId={districtId}");

            var districtSettingModel = new DistrictSettingsModel
            {
                DistrictId = districtId,
                SalesManDetailsModel = salesManDetailsModel
            };
            return View(viewName: "Settings", model: districtSettingModel);
        }

        [HttpPost]
        public async Task<ActionResult> Settings(DistrictSettingsModel districtSettingsModel)
        {
            districtSettingsModel.SalesManDetailsModel.ForEach(o => o.DistrictId = districtSettingsModel.DistrictId);
            var test = await PostAsync("SalesMen/UpdateSalesManDistrictAndResponsability", districtSettingsModel.SalesManDetailsModel);

            return RedirectToAction("Index", "Districts");
            
        }
    }
}