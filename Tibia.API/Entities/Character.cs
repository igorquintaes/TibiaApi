using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;
using Tibia.API.Enums;

namespace Tibia.API.Entities
{
    internal class Character : ICharacter
    {
        public AccountStatus AccountStatus { get; set; }
        public int AchievementPoints { get; set; }
        public ICollection<IAchievement> Achievements { get; set; }
        public ICollection<ICharacter> Characters { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public IGuildMembership GuildMembership { get; set; }
        public DateTime LastLogin { get; set; }
        public int Level { get; set; }
        public string LoyalityTitle { get; set; }
        public string MarriedTo { get; set; }
        public string Name { get; set; }
        public string Residence { get; set; }
        public Sex Sex { get; set; }
        public Vocation Vocation { get; set; }
        public string World { get; set; }
    }
}
