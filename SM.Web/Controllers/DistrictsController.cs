
using SM.Web.Models.Districts;
using SM.Web.Models.SalesMen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace SM.Web.Controllers
{
    public class DistrictsController : BaseController
    {
        // GET: Districts
        public ActionResult Index()
        {
            IList<DistrictModel> districtstModel = null;

            //todo - bag usingul cu tot ce se poate intr-un base
            //trim parametru numele metodei, pun base api url in config

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58836/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Districts/GetAllDistricts");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<DistrictModel>>();
                    readTask.Wait();

                    districtstModel = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //students = Enumerable.Empty<StudentViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(districtstModel);
        }

        [HttpGet]
        public ActionResult Details(int districtId)
        {

            DistrictDetailsModel districtDetailsModel = GetAsync<DistrictDetailsModel>($"Districts/GetDistrictDetailsById?districtId={districtId}");
            return View(viewName: "Details", model: districtDetailsModel);
        }

        [HttpGet]
        public ActionResult Settings(int districtId)
        {

            // ViewBag["testList"] = Enum.GetValues(typeof(SalesManResponsabilityTypes)).AsQueryable().OfType<SalesManResponsabilityTypes>().Select(e => new SelectListItem() { Value = ((int)e).ToString(), Text = e.ToString() }).ToList();

            IList<SalesManDetailsModel> salesManDetailsModel = GetAsync<IList<SalesManDetailsModel>>("SalesMen/GetSalesMenDetails");
            return View(viewName: "Settings", model: salesManDetailsModel);
        }

        [HttpPost]
        public ActionResult Settings(SalesManDetailsModel portocala)
        {

            return View();
        }
    }
}