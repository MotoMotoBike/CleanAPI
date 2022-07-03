using Games.Application.Common.Exeptions;
using Games.Application.Games.Commands.Create;
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

namespace Games.Application.Games.Commands
{
    internal class UpdateGameCommandHandler : IRequestHandler<UpdateGameCommand, Guid>
    {
        private readonly IGamesDbContext _dbContext;

        public UpdateGameCommandHandler(IGamesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            var game = 
                await _dbContext.Games.FirstOrDefaultAsync(game => 
                    game.Id == request.Id, cancellationToken);

            if(game == null || game.Id != request.Id)
            {
                throw new NotFoundExeption(nameof(Game),request.Id);
            }

            game.Name = request.Name;
            
            await _dbContext.SaveChangesAsync(cancellationToken);

            return game.Id;
        }

        public Task<Guid> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
