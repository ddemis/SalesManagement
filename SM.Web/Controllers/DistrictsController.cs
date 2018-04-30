using SM.Web.Models.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class DistrictsController : Controller
    {
        // GET: Districts
        public ActionResult Index()
        {
            DistrictDetailsResultModel districtDetailsResultModel = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58836/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Districts/GetDistrictDetails?startRowNo=1&noOfRowsToGet=2");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DistrictDetailsResultModel>();
                    readTask.Wait();

                    districtDetailsResultModel = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //students = Enumerable.Empty<StudentViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(districtDetailsResultModel);
        }
    }
}