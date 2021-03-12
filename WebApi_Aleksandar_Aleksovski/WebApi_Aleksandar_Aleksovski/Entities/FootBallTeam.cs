using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Entities
{
    public class FootBallTeam

    {
        public int Id { get; set; }
        public string ImeTrener { get; set; }
        public string PrezimeTrener { get; set; }
        public int Golovi { get; set; } // = new List<int>();  //   public List<int> Golovi { get; set; }
        public double Dostignuvanje { get; set; }

        public double Koeficient = 2.0;

        public virtual ICollection<NatoinalTeam> NatoinalTeams { get;set;}
        public virtual ICollection<Club> Clubs { get; set; } 
    }
}
