using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Entities;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
    public interface IFootballTeamServices
    {
        List<FootBallTeam> Get();
        FootBallTeam Get(int id);
        FootBallTeam Add(FootBallTeam ft );
        FootBallTeam Update(FootBallTeam footBallTeam);

        bool Delete(int id);
    }

}

