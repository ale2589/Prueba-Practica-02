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
    public class PlayerSeasonController : Controller
    {
        private readonly string Baseurl = "https://api-football-v1.p.rapidapi.com";

        // GET: PlayerSeason
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ObtenerTempJugador()
        {
            using (var client = new HttpClient())
            {
                //List<TeamSeason> teamSeasons = new List<TeamSeason>();
                List<int> teamSeasons = new List<int>();
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5d98c4774dmsh2f40f60b75663cap1eca5cjsn9ff83f3a465d");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");

                HttpResponseMessage response = await client.GetAsync($"v3/players/seasons");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    //teamSeasons = JsonConvert.DeserializeObject<TeamSeasonResponse>(jsonResponse);
                    var teamSeasonResponse = JsonConvert.DeserializeObject<TeamSeasonResponse>(jsonResponse);
                    teamSeasons = teamSeasonResponse.Response;
                }


                return View(teamSeasons);
            }
        }
    }
}