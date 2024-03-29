﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Aleksandar_Aleksovski.Entities
{
    public class NatoinalTeam
    {
        public int Id { get; set; }
        public string Drzava { get; set; }
        public int MegunarodniNastapi { get; set; }

        [ForeignKey("FootBallTeamId")]
        public virtual FootBallTeam FootBallTeam { get; set; }
        public int FootBallTeamId { get; set; }
    }
}
