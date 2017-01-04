using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Entities.Contracts
{
    public interface IGuildRanking
    {
        string Name { get; }
        int Position { get; }
    }
}
