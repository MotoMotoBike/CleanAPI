using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Games.Application.Interfaces;

namespace Games.Presistance
{
    public static class DependensyInjection
    {
        public static IServiceCollection AddPercistance(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["ConnectinString"];
            services.AddDbContext<GamesDBContext>(i => i.UseInMemoryDatabase(connectionString));
            services.AddScoped<IGamesDbContext>(i => i.GetService<GamesDBContext>());
            return services;
        }
    }
}
