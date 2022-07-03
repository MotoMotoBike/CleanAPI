using Games.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Games.Application.Interfaces
{
    public interface IGamesDbContext
    {
        DbSet<Game> Games { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
