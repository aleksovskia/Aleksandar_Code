using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Entities;

namespace WebApi_Aleksandar_Aleksovski.Services.Interfaces
{
    public interface IClubServices
    {
        List<Club> Get();
        Club Get(int id);
        Club Add(Club c );
        Club Update(Club club);
        bool Delete(int id);
        public double Achievement(List<Club> club);
        public double Achievement(int clubId);
    }

}

