﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Domain
{
    public class Developer
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public ICollection<Game> Games { get; set; }
    }
}
