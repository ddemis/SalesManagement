using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
                
                var responseTask = client.GetAsync(requestUri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsAsync<T>();
                }
                else
                {
                    //display request message to user
                    return default(T);
                }
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
                }
                else
                {
                    //display request message to user
                    return false;
                }
            }
        }
    }
}