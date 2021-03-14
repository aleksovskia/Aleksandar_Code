using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Entities;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
    public interface INatoinalTeamServices
    {
        List<NatoinalTeam> Get();
        NatoinalTeam Get(int id);
        NatoinalTeam Add(NatoinalTeam nt);
        NatoinalTeam Update(NatoinalTeam natoinalTeam);
        bool Delete(int id);
        public double Achievement(List<NatoinalTeam> natoinalTeams);
        public double Achievement(int footballTeamId);
    }
      
    

}

