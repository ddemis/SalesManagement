using SM.Web.Models.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class DistrictManagementController : BaseController
    {
        // GET: DistrictManagement
        public ActionResult Index()
        {
            IList<DistrictModel> districtModel = GetAsync<IList<DistrictModel>>("Districts");
            return View(districtModel);
        }
    }
}