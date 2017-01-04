using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Services.Contracts
{
    public interface IRequestService
    {
        IEnumerable<ICharacter> GetOnlineCharacters(string world);

        ICharacter GetCharacterInformation(string characterName);

        IEnumerable<IGuild> GetAllGuilds(string world);

        IGuild GetGuildInformation(string guildName);
    }
}
