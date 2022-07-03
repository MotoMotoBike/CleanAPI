﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Games.Commands
{
    public class UpdateGameCommand : IRequest<Guid>
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
