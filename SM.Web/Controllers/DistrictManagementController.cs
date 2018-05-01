using SM.Web.Models.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class DistrictManagementController : BaseController
    {
        // GET: DistrictManagement
        public async Task<ActionResult> Index()
        {
            IList<DistrictModel> districtModel = await GetAsync<IList<DistrictModel>>("Districts");
            return View(districtModel);
        }
    }
}