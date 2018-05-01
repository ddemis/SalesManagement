using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SM.Web.Controllers
{
    public class BaseController : Controller
    {
        public async Task<T> GetAsync<T>(string requestUri)
        {
            using (var client = new HttpClient())
            {
                //mut url in config
                client.BaseAddress = new Uri("http://localhost:58836/api/");
                //HTTP GET
                var responseTask = client.GetAsync(requestUri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsAsync<T>();
                    //var readTask = result.Content.ReadAsAsync<T>();
                    //readTask.Wait();

                    //return readTask.Result;
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

        public async Task<bool> PostAsync<T>(string requestUri, T data)
        {
            using (var client = new HttpClient())
            {
                //mut url in config
                client.BaseAddress = new Uri("http://localhost:58836/api/");

                var json = JsonConvert.SerializeObject(data);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var responseTask = client.PostAsync(requestUri, stringContent);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsAsync<bool>();
                    //var readTask = result.Content.ReadAsAsync<T>();
                    //readTask.Wait();

                    //return readTask.Result;
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