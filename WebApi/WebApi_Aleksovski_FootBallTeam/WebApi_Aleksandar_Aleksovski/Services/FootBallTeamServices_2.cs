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
    public class FootBallTeamServices_2 : IFootBallTeamServices_2
    {
        public FootbaalTeam FootbaalTeam { get; set; }
        public FootBallTeamServices_2(string imeTrener)
        {
            FootbaalTeam = new FootballTeamHelpers().CreateFoodballTeam(imeTrener);
        }
        public FootbaalTeam GetName(string imeTrener)
        {
            var trener =FootbaalTeam.ListaNaTimovi.FirstOrDefault(x=>x.ImeTrener==imeTrener);
            return trener;
        }
        public FootbalTeamModelRequest GetAchievement(string imeTrener)
        {
            var trener = FootbaalTeam.ListaNaTimovi.FirstOrDefault(x => x.ImeTrener == imeTrener);
            var foodbalTeamModelRequest = new FootbalTeamModelRequest()
            {
                ImeTrener = trener.ImeTrener,
                Dostignuvanje = trener.Achievement(),
                PrezimeTrener = trener.PrezimeTrener
            };
            return foodbalTeamModelRequest;
        }    
        public FootbalTeamModelResponce GetFoodbalTeamGolovi(string imeTrener)
        {
           var trener = FootbaalTeam.ListaNaTimovi.FirstOrDefault(x => x.ImeTrener == imeTrener);
           var print = trener.Pecati();
           var foodbalTeamModelResponce = new FootbalTeamModelResponce()
           {
               ImeTrener = trener.ImeTrener,
               BrojNaGlovi = trener.BrojNaGolovi(),
               PrezimeTrener =trener.PrezimeTrener
           };
            return foodbalTeamModelResponce;
        }
    }
}
