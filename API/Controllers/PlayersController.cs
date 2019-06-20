using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;
using Domain.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPoolChampionService _poolChampion;

        public PlayersController(IPoolChampionService poolChanpion)
        {
            _poolChampion = poolChanpion;
        }

        public async Task<ActionResult> GetPlayers()
        {
           return new OkObjectResult( await _poolChampion.GetAllPlayers()); // only returns name and Id.
           
        }

        public async Task<ActionResult> SignUp(PlayerRequest player)
        {
            return new OkObjectResult( await _poolChampion.AddPlayer(player.Name,player.Email)); // all params EXCEPT id
        }
    }
}
