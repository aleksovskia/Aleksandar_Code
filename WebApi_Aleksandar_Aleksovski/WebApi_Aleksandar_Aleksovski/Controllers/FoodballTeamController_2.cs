using WebApi_Aleksandar_Aleksovski.Helpers;
using WebApi_Aleksandar_Aleksovski.Services;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodballTeamController_2 : ControllerBase
    {
        private readonly IFoodBallTeamServices_2 _foodballteamServices_2;
        public FoodballTeamController_2 (IFoodBallTeamServices_2 foodBallTeam)
        {
            _foodballteamServices_2 = foodBallTeam;
        }

        //GET Request - https://localhost:44337/foodballTeam/Golovi/Aleksandar
        [HttpGet]
        [Route("Golovi/{imeTrener}")]
        public string Golovi()
        {
           var golovi = _foodballteamServices_2.GetFoodbalTeamGolovi("Aleksandar");
           var jsonString = JsonSerializer.Serialize (golovi);
           return jsonString;
        }
        //post Responce - https://localhost:44337/FoodballTeam/dostignuvanje/Aleksandar
        [HttpPost]
        [Route("dostignuvanje/{imeTrener}")]
        public string Dostignuvanje(string imeTrener)
        {
             var dostignuvanje = _foodballteamServices_2.GetAchievement(imeTrener);
             var jasonString = JsonSerializer.Serialize(dostignuvanje);
             return jasonString;
          // return _foodballteamServices.GetAchievement(imeTrener);
        }

    } 
}
