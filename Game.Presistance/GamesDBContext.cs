using Games.Application.Interfaces;
using Games.Domain;
using Games.Presistance.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Presistance
{
    public class GamesDBContext : DbContext, IGamesDbContext
    {
        public DbSet<Game> Games { get; set; }

        public GamesDBContext(DbContextOptions<GamesDBContext> options) 
            : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
