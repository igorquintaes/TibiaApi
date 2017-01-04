using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Entities.Contracts
{
    public interface IGuildMembership
    {
        IGuild Guild { get; }
        ICharacter Character { get; }
        IGuildRanking Ranking { get; }
        DateTime JoinedDate { get; }
        bool IsOnline { get; }
    }
}
