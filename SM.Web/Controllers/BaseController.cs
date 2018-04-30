using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public T GetAsync<T>(string requestUri)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58836/api/");
                //HTTP GET
                var responseTask = client.GetAsync(requestUri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<T>();
                    readTask.Wait();

                    return readTask.Result;
                }
                else
                {
                    //TODO - fix this - new object that contains T and status code
                    throw new Exception();
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    //students = Enumerable.Empty<StudentViewModel>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");


                //}
            }
        }
    }
}