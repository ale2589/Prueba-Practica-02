using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Football.Models;
using Newtonsoft.Json;

namespace Football.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        private readonly string Baseurl = "https://api-football-v1.p.rapidapi.com";
        // GET: Countries
        public async Task<ActionResult> Index()
        {
            List<Countries> CountryInfo = new List<Countries>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5d98c4774dmsh2f40f60b75663cap1eca5cjsn9ff83f3a465d");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");


                HttpResponseMessage Res = await client.GetAsync("v3/teams/countries/");
                if (Res.IsSuccessStatusCode)
                {
                    var CnResponse = Res.Content.ReadAsStringAsync().Result;
                    //EmpInfo = JsonConvert.DeserializeObject<List<Countries>>(EmpResponse);
                    var countryResponse = JsonConvert.DeserializeObject<CountryResponse>(CnResponse);
                    CountryInfo = countryResponse.Response;
                }
                return View(CountryInfo);
            }

        }
    }
}