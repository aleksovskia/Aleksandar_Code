using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string ImeNaKlubot { get; set; }
        public int BrojNaMedalji { get; set; }
       
        [ForeignKey("FootBallTeamId")]
        public virtual FootBallTeam FootBallTeam { get; set; }
        public int FootBallTeamId { get; set; }
    }
}

