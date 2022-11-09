using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blocket.DataContracts;

namespace Blocket.DataContracts
{
    public record CreateItem
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
