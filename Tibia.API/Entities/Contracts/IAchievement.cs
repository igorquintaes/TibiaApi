using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Entities.Contracts
{
    public interface IAchievement
    {
        int Rarity { get; }
        string Name { get; }
    }
}
