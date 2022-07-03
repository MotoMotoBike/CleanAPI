using Games.Application.Games.Commands;
using Games.Application.Games.Commands.Create;
using Games.Application.Games.Commands.Delete;
using Games.Application.Games.Quetys.GetGamesList;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Games.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController : BaseController
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var query = new GetGameListQuery();
            var vm = Mediator.Send(query);
            return new ObjectResult(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Add(string name)
        {
            var query = new CreateGameCommand
            {
                Name = name
            };
            var vm = Mediator.Send(query);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<GamesListVM>> Update(Guid id, string name)
        {
            var query = new UpdateGameCommand
            {
                Id = id,
                Name = name
            };

            var vm = Mediator.Send(query);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<GamesListVM>> Delete(Guid id)
        {
            var query = new DeleteGameCommand
            {
                Id = id
            };

            var vm = Mediator.Send(query);
            return Ok();
        }
    }
}
