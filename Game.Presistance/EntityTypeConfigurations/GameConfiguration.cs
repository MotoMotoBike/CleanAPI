using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Presistance.EntityTypeConfigurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        Guid gameId1 = Guid.NewGuid();
        Guid gameId2 = Guid.NewGuid();
        Guid gameId3 = Guid.NewGuid();

        public List<Game> games = new List<Game>();

        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.HasOne(i => i.Developer).WithMany(i => i.Games);

            games.Add(new Game()
            {
                Id = gameId1,
                Name = "StarCraft2"
            });

            builder.HasData(games.Last());

            games.Add(new Game()
            {
                Id = gameId2,
                Name = "Overwatch"
            });

            builder.HasData(games.Last());

            games.Add(new Game()
            {
                Id = gameId3,
                Name = "The Elder Scrolls | Skyrim",
            });

            builder.HasData(games.Last());
        }
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(entity => entity.Id);
        }
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasKey(entity => entity.Id);

            builder.HasData(new Developer()
            {
                Id = Guid.NewGuid(),
                Name = "Blizzard",
                Games = games
            }) ;
        }
    }
}
