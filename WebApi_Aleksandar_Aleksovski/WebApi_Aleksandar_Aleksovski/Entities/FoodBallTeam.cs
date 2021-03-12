using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Entities
{
    public class FoodBallTeam

    {
        public int Id { get; set; }
        public string ImeTrener { get; set; }
        public string PrezimeTrener { get; set; }
        public  int Golovi { get; set; } // = new List<int>();
       // public virtual ICollection<FoodBallTeam> ListaNaTimovi { get; set; } // = new List<FootbaalTeam>();
        public double Dostignuvanje { get; set; }

        public double Koeficient = 2.0;
    }
}
