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
    public class GamesController : ControllerBase
    {
        private readonly IPoolChampionService _poolChampion;

        public GamesController(IPoolChampionService poolChanpion)
        {
            _poolChampion = poolChanpion;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> CreateGame(Domain.Player player1, Domain.Player player2)
        {
            await _poolChampion.CreateGame(player1, player2);
            return new OkResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ConfirmGame(long id)
        {
            return new OkObjectResult(await _poolChampion.Confirm(id));
        }
    }
}
