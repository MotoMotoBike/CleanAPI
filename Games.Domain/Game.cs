using System;
using System.Collections.Generic;

namespace Games.Domain
{
    public class Game
    {
        public Guid DeveloperId { get; set; }
        
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<GameGenre> gameGenres { get; set; } = new List<GameGenre>();
        
        public Developer Developer { get; set; }

    }
}
