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
        private List<IAchievement> _achievements { get; set; }
        public ICollection<IAchievement> Achievements { get { return (_achievements ?? (_achievements = new List<IAchievement>())); } }

        private List<ICharacter> _characters { get; set; }
        public ICollection<ICharacter> Characters { get { return (_characters ?? (_characters = new List<ICharacter>())); } }

        private List<ICharacterDeath> _deaths { get; set; }
        public ICollection<ICharacterDeath> Deaths { get { return (_deaths ?? (_deaths = new List<ICharacterDeath>())); } }

        public AccountStatus AccountStatus { get; set; }
        public int AchievementPoints { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public IGuildMembership GuildMembership { get; set; }
        public DateTime LastLogin { get; set; }
        public int Level { get; set; }
        public string LoyalityTitle { get; set; }
        public ICharacter MarriedTo { get; set; }
        public string Name { get; set; }
        public string Residence { get; set; }
        public Sex Sex { get; set; }
        public Vocation Vocation { get; set; }
        public string World { get; set; }

        public Character()
        {
            _achievements = new List<IAchievement>();
            _characters = new List<ICharacter>();
            _deaths = new List<ICharacterDeath>();
        }

        internal void AddAchievement(IAchievement achievement)
        {
            if (achievement == null) throw new ArgumentNullException("achievement");

            _achievements.Add(achievement);
        }
        internal void AddAchievement(List<IAchievement> achievements)
        {
            if (achievements == null || achievements.Any(x => x == null))
                throw new ArgumentNullException("achievements");

            _achievements.AddRange(achievements);
        }

        internal void AddDeath(ICharacterDeath death)
        {
            if (death == null)
                throw new ArgumentNullException("death");

            _deaths.Add(death);
        }
        internal void AddDeath(List<ICharacterDeath> deaths)
        {
            if (deaths == null || deaths.Any(x => x == null))
                throw new ArgumentNullException("deaths");

            _deaths.AddRange(deaths);
        }
    }
}
