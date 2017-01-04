using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Entities
{
    internal class Guild : IGuild
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Founded { get; set; }
        public IGuildHouse GuildHouse { get; set; }
        public string ImgUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsOpenedForApplications { get; set; }

        private List<IGuildMembership> _members;
        public ICollection<IGuildMembership> Members
        {
            get
            {
                return _members ?? (_members = new List<IGuildMembership>());
            }
        }

        private List<IGuildInvitedCharacter> _invitedCharacters;
        public ICollection<IGuildInvitedCharacter> InvitedCharacters
        {
            get
            {
                return _invitedCharacters ?? (_invitedCharacters = new List<IGuildInvitedCharacter>());

            }
        }
    }
}
