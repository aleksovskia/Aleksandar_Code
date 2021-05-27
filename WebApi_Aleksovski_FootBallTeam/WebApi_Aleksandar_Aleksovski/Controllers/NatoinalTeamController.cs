
using WebApi_Aleksandar_Aleksovski.Services;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi_Aleksandar_Aleksovski.Entities;

namespace WebApi_Aleksandar_Aleksovski.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NatoinalTeamController : ControllerBase
    {
        private readonly INatoinalTeamServices _natoinalTeamServices;
        public NatoinalTeamController(INatoinalTeamServices natoinalTeam)
        {
            _natoinalTeamServices = natoinalTeam;
        }

        [HttpGet]
        public List<NatoinalTeam> Get()
        {

            return _natoinalTeamServices.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public NatoinalTeam Get(int id)
        {
            return _natoinalTeamServices.Get(id);
        }


        [HttpPost]
        [Route("create")]
        public NatoinalTeam Create(NatoinalTeam model)
        {
            return _natoinalTeamServices.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public NatoinalTeam Update(NatoinalTeam club)
        {
            return _natoinalTeamServices.Update(club);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _natoinalTeamServices.Delete(id);
        }

        [HttpGet]
        [Route("{id}/Achievement")]
        public double Achievement(int id)
        {
            return _natoinalTeamServices.Achievement(id);
        }
    }


}
