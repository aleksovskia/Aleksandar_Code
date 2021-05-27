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
    public class ClubController : ControllerBase
    {
        private readonly IClubServices _clubServices;
        public ClubController(IClubServices club)
        {
            _clubServices = club;
        }

        [HttpGet]
        public List<Club> Get()
        {

            return _clubServices.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Club Get(int id)
        {
            return _clubServices.Get(id);
        }


        [HttpPost]
        [Route("create")]
        public Club Create(Club model)
        {
            return _clubServices.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public Club Update(Club club)
        {
            return _clubServices.Update(club);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _clubServices.Delete(id);
        }
        [HttpGet]
        [Route("{id}/Achievement")]
        public double Achievement(int id)
        {
            return _clubServices.Achievement(id);
        }


    } 
}
