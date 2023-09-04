using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Football.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace Football.Controllers
{
    public class PlayerController : Controller
    {
        private readonly string Baseurl = "https://api-football-v1.p.rapidapi.com";
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }
        //public async Task<ActionResult> ObtenerInfoEquipo(int teamId)
        public async Task<ActionResult> ObtenerInfoEquipo()


        {
            using (var client = new HttpClient())
            {
                //TeamInfo teamInfo = null;
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5d98c4774dmsh2f40f60b75663cap1eca5cjsn9ff83f3a465d");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");

                //HttpResponseMessage response = await client.GetAsync($"v3/players/squads?team={teamId}");
                HttpResponseMessage response = await client.GetAsync($"v3/players/squads?team=33");


                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var teamInfo = JsonConvert.DeserializeObject<TeamInfo>(jsonResponse);
                    return View(teamInfo);

                }else

                    return View("Index");




            }
        }

    }
}