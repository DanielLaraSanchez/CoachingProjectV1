using DataLayer.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using API.Requests;

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
        public async Task<ActionResult<Game>> CreateGame(GameRequest request)
        {
            await _poolChampion.CreateGame(request.Player1, request.Player2);
            return new OkResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ConfirmGame(long playerId, long gameId)
        {
            return new OkObjectResult(await _poolChampion.Confirm(playerId, gameId));
        }
    }
}
