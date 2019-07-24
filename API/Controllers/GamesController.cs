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
        private readonly IPoolChampionService _poolChampionService;

        public GamesController(IPoolChampionService poolChanpionService)
        {
            _poolChampionService = poolChanpionService;
        }

        [HttpPost("{creategame}")]
        public async Task<ActionResult<Game>> CreateGame(GameRequest request)
        {
            await _poolChampionService.CreateGame(request.Player1, request.Player2);
            return new OkResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ConfirmGame(long playerId, long gameId)
        {
            return new OkObjectResult(await _poolChampionService.Confirm(playerId, gameId));
        }
    }
}
