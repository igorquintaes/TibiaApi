using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Entities.Contracts
{
    public interface IGuildInvitedCharacter
    {
        ICharacter Character {get; }
        DateTime InvitationDate { get; }
    }
}
