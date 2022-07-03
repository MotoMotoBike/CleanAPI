using Games.Application.Interfaces;
using Games.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Games.Application.Games.Commands.Create
{
    public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, Guid>
    {
        private readonly IGamesDbContext _dbContext;

        public CreateGameCommandHandler(IGamesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            Game game = new Game()
            {
                Id = request.Id,
                Name = request.Name
            };

            await _dbContext.Games.AddAsync(game);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return game.Id;
        }
    }
}
