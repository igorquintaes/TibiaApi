using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Entities
{
    internal class GuildInvitedCharacter : IGuildInvitedCharacter
    {
        public ICharacter Character { get; set; }
        public DateTime InvitationDate { get; set; }
    }
}
