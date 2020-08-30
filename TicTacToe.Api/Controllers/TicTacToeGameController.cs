using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Business.Entities;
using TicTacToe.Business.Interface;
namespace TicTacToe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicTacToeGameController : ControllerBase
    {
        private readonly IGame _iGame ;

        public TicTacToeGameController(IGame iGame)
        {
            _iGame = iGame;
        }
        [HttpPost]
        public ActionResult<Player> PostTodoItem([FromBody] List<Position> positions)
        {
            return _iGame.Play(positions);
        }
    }
}