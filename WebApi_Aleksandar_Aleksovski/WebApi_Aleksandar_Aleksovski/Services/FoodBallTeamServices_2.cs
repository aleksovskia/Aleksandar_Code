using WebApi_Aleksandar_Aleksovski.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using System.Text.Json;
using Newtonsoft.Json;

namespace WebApi_Aleksandar_Aleksovski.Services
{
    public class FoodBallTeamServices_2 : IFoodBallTeamServices_2
    {
        public FootbaalTeam FootbaalTeam { get; set; }
        public FoodBallTeamServices_2(string imeTrener)
        {
            FootbaalTeam = new FoodballTeamHelpers().CreateFoodballTeam(imeTrener);
        }
        public FootbaalTeam GetName(string imeTrener)
        {
            var trener =FootbaalTeam.ListaNaTimovi.FirstOrDefault(x=>x.ImeTrener==imeTrener);
            return trener;
        }
        public FoodbalTeamModelRequest GetAchievement(string imeTrener)
        {
            var trener = FootbaalTeam.ListaNaTimovi.FirstOrDefault(x => x.ImeTrener == imeTrener);
            var foodbalTeamModelRequest = new FoodbalTeamModelRequest()
            {
                ImeTrener = trener.ImeTrener,
                Dostignuvanje = trener.Achievement(),
                PrezimeTrener = trener.PrezimeTrener
            };
            return foodbalTeamModelRequest;
        }    
        public FoodbalTeamModelResponce GetFoodbalTeamGolovi(string imeTrener)
        {
           var trener = FootbaalTeam.ListaNaTimovi.FirstOrDefault(x => x.ImeTrener == imeTrener);
           var print = trener.Pecati();
           var foodbalTeamModelResponce = new FoodbalTeamModelResponce()
           {
               ImeTrener = trener.ImeTrener,
               BrojNaGlovi = trener.BrojNaGolovi(),
               PrezimeTrener =trener.PrezimeTrener
           };
            return foodbalTeamModelResponce;
        }
    }
}
