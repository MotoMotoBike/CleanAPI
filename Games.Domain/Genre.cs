using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Domain
{
    public class Genre
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<GameGenre> gameGenres { get; set; } = new List<GameGenre>();
        
    }
}
