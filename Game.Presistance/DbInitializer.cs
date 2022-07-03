using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Presistance
{
    public class DbInitializer
    {
        public static void Initialize(GamesDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
