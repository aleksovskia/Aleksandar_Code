using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Helpers;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
   public interface IFootBallTeamServices_2

    {
        FootbaalTeam  FootbaalTeam { get; set; }
      
        FootbaalTeam GetName(string imeTrener);
        FootbalTeamModelResponce GetFoodbalTeamGolovi(string imeTrener);
        FootbalTeamModelRequest GetAchievement(string imeTrener);
    }
}
