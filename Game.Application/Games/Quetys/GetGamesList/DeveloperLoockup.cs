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
    public class DeveloperLoockup : IMapWith<Developer>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Developer, DeveloperLoockup>()
                .ForMember(developer => developer.Id,
                    opt => opt.MapFrom(developer => developer.Id))
                .ForMember(developer => developer.Name,
                    opt => opt.MapFrom(developer => developer.Name));
        }
    }
}
