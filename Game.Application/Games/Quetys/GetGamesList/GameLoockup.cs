using AutoMapper;
using Games.Application.Common.Mappings;
using Games.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Games.Quetys.GetGamesList
{
    public class GameLoockup : IMapWith<Game>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<Game, GameLoockup>()
                .ForMember(game => game.Id,
                    opt => opt.MapFrom(game => game.Id))
                .ForMember(game => game.Name,
                    opt => opt.MapFrom(game => game.Name));
        }
    }
}
