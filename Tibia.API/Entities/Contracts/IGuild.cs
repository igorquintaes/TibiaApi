using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tibia.API.Entities.Contracts
{
    public interface IGuild
    {
        string Name { get; }
        string Description { get; }
        string ImgUrl { get; }
        DateTime Founded { get; }
        bool IsActive { get; }
        bool IsOpenedForApplications { get; }
        IGuildHouse GuildHouse { get; }

        ICollection<IGuildMembership> Members { get; }

        ICollection<IGuildInvitedCharacter> InvitedCharacters { get; }
    }
}
