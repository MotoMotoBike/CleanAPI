using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Domain
{
    public class GameGenre
    {
        public Guid Id { get; set; }

        public Guid GameId { get; set; }

        public Guid GenreId { get; set; }

        public Game Game { get; set; }

        public Genre Genre { get; set; }
    }
}
