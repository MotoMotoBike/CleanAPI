using Games.Application.Common.Exeptions;
using Games.Application.Interfaces;
using Games.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Games.Application.Games.Commands.Delete
{
    public class DeleteGameCommandHandler : IRequestHandler<DeleteGameCommand, Guid>
    {
        private readonly IGamesDbContext _dbContext;

        public DeleteGameCommandHandler(IGamesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(DeleteGameCommand request, CancellationToken cancellationToken)
        {

            var game =
                await _dbContext.Games.FirstOrDefaultAsync(game =>
                    game.Id == request.Id, cancellationToken);

            if (game == null || game.Id != request.Id)
            {
                throw new NotFoundExeption(nameof(Game), request.Id);
            }

            _dbContext.Games.Remove(game);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return game.Id;
        }
    }
}