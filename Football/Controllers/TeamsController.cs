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
    public class TeamsController : Controller
    {
        private readonly string Baseurl = "https://api-football-v1.p.rapidapi.com";
        // GET: Teams
        /*public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                List<Teams> TeamInfo = new List<Teams>();
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5d98c4774dmsh2f40f60b75663cap1eca5cjsn9ff83f3a465d");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");

                HttpResponseMessage Res = await client.GetAsync("v3/teams"); // Usar el UserId seleccionado
                if (Res.IsSuccessStatusCode)
                {
                    var TmResponse = await Res.Content.ReadAsStringAsync();
                    var Resp = JsonConvert.DeserializeObject<TeamResponse>(TmResponse);
                    return View("Index", Resp.Response);
                }
                else

                    return View("Index");
            }

        }*/
        [HttpGet]
        //public async Task<ActionResult> Index(int UserId)
        public async Task<ActionResult> Index()

        {

            using (var client = new HttpClient())
            {
                List<Teams> TeamInfo = new List<Teams>();
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5d98c4774dmsh2f40f60b75663cap1eca5cjsn9ff83f3a465d");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");

                //HttpResponseMessage Res = await client.GetAsync("v3/teams?id=10" + Convert.ToString(UserId)); // Usar el UserId seleccionado
                HttpResponseMessage Res = await client.GetAsync("v3/teams?id=10"); // Usar el UserId seleccionado

                if (Res.IsSuccessStatusCode)
                {
                    var TmResponse = await Res.Content.ReadAsStringAsync();
                    var Resp = JsonConvert.DeserializeObject<TeamResponse>(TmResponse);
                    return View("Index", Resp.Response);
                }else

                return View("Index");
            }
        }

    }
}