using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Application.Common.Exeptions
{
    public class NotFoundExeption : Exception
    {
        public NotFoundExeption(string name, object key)
            : base($"Entity\"{name}\" ({key}) Not found") { }
    }
}
