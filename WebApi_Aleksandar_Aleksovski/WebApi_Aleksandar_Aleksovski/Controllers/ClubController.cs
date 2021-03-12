﻿using WebApi_Aleksandar_Aleksovski.Helpers;
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
    public class Club : ControllerBase
    {
        private readonly IClubServices _clubServices;
        public Club (IClubServices club)
        {
            _clubServices = club;
        }
      

    } 
}