using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Games.Commands.Delete
{
    public class DeleteGameCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
