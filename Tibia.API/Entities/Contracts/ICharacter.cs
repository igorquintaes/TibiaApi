using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Enums;

namespace Tibia.API.Entities.Contracts
{
    public interface ICharacter
    {
        // Character Information
        string Name { get; }
        Vocation Vocation { get; }
        int Level { get; }
        Sex Sex { get; }
        int AchievementPoints { get; }
        string World { get; }
        string Residence { get; }
        ICharacter MarriedTo { get; }
        IGuildMembership GuildMembership { get; }
        DateTime LastLogin { get; }
        string Comment { get; }
        AccountStatus AccountStatus { get; }

        // Account Achievements
        ICollection<IAchievement> Achievements { get; }

        // Deaths
        ICollection<ICharacterDeath> Deaths { get; }

        // Account Information
        string LoyalityTitle { get; }
        DateTime CreatedDate { get; }

        // Characters 
        ICollection<ICharacter> Characters { get; } 
    }
}
