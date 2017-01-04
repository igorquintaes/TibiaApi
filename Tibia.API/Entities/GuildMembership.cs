using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Entities
{
    internal class GuildMembership : IGuildMembership
    {
        public ICharacter Character { get; set; }
        public IGuild Guild { get; set; }
        public bool IsOnline { get; set; }
        public DateTime JoinedDate { get; set; }
        public IGuildRanking Ranking { get; set; }
    }
}
