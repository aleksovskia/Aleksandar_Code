using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Entities;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
    public interface IFoodballTeamServices
    {
        List<FoodBallTeam> Get();
        FoodBallTeam Get(int id);
        FoodBallTeam Add(FoodBallTeam ft );
        FoodBallTeam Update(FoodBallTeam foodBallTeam);
        bool Delete(int id);
    }

}

