using AutoMapper;
using Games.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace Games.Application.Games.Quetys.GetGamesList
{
    public class GetGamesListQueryHandler : IRequestHandler<GetGameListQuery, GamesListVM>
    {
        private readonly IGamesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetGamesListQueryHandler(IGamesDbContext dbContext,
            IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<GamesListVM> Handle(GetGameListQuery request, CancellationToken cancellationToken)
        {
            var gamesList = await _dbContext.Games.ProjectTo<GameLoockup>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new GamesListVM { Games = gamesList};
        }
    }
}
