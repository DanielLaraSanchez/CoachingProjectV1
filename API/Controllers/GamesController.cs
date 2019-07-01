using DataLayer.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<ActionResult<Game>> CreateGame(DataLayer.Entities.Player player1, DataLayer.Entities.Player player2)
        {
            await _poolChampion.CreateGame(player1, player2);
            return new OkResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ConfirmGame(long playerId, long gameId)
        {
            return new OkObjectResult(await _poolChampion.Confirm(playerId, gameId));
        }
    }
}
