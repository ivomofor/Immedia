using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Immedia.Models;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Immedia.Controllers
{
    [Authorize]
    public class DataController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;
        public DataController(IHttpClientFactory clientFactory)
        {
            httpClientFactory = clientFactory;
        }
        public IActionResult Error()
        {
            return View();
        }

        
        public async Task<IActionResult> IndexAsync(string City)
        {

            string ClientID = "WK52KP0S5DRUAHUV1W1BJLLH5DMOMRR531KYZK5MDEDYH4F4";
            string ClientSecret = "5ZZ3NF0MR2TI3XEV4SX20T2JTBDWCZINNVSFQ0JDVBCUVGG4";
            string url = $"https://api.foursquare.com/v2/venues/search?&client_id={ClientID}&client_secret={ClientSecret}&v=20180323&near={City}";

            if(ModelState.IsValid)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var json = await client.GetStringAsync(url);
                        var response = JsonConvert.DeserializeObject<Root>(json);
                        return View(response);
                    }
                }
                catch
                {
                    return View(nameof(Error));
                }
            }
            return View(City);
        }
    }
}
