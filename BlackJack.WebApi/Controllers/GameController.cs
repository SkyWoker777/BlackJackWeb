using BlackJack.Business.Services;
using BlackJack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlackJack.WebApi.Controllers
{
    [RoutePrefix("api/game")]
    public class GameController : ApiController
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        [Route("start")]
        public async Task<IHttpActionResult> Start([FromBody] StartGameView model)
        {
            MainGameView view = await _gameService.NewGame(model);
            return Ok(view);
        }
    }
}