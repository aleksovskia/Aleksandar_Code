using WebApi_Aleksandar_Aleksovski.Entities;
using WebApi_Aleksandar_Aleksovski.Services;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public  class FootballTeamController : ControllerBase
    {
        private readonly IFootballTeamServices _foodBallTeamServices;
        public FootballTeamController(IFootballTeamServices footBallTeam)
        {
            _foodBallTeamServices = footBallTeam;
        }

        [HttpGet]
        public List<FootBallTeam> Get()
        {

            return _foodBallTeamServices.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public FootBallTeam Get(int id)
        {
            return _foodBallTeamServices.Get(id);
        }


        [HttpPost]
        [Route("create")]
        public FootBallTeam Create(FootBallTeam model)
        {
            return _foodBallTeamServices.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public FootBallTeam Update(FootBallTeam footBallTeam)
        {
            return _foodBallTeamServices.Update(footBallTeam);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _foodBallTeamServices.Delete(id);
        }



    }



}
