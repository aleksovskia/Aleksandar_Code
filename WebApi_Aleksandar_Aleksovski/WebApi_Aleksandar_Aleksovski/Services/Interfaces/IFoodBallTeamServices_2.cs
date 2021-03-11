using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Helpers;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
   public interface IFoodBallTeamServices_2

    {
        FootbaalTeam  FootbaalTeam { get; set; }
      
        FootbaalTeam GetName(string imeTrener);
        FoodbalTeamModelResponce GetFoodbalTeamGolovi(string imeTrener);
        FoodbalTeamModelRequest GetAchievement(string imeTrener);
    }
}
