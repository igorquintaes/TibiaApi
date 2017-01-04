using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Entities
{
    internal class GuildRanking : IGuildRanking
    {
        public string Name { get; set; }
        public int Position { get; set; }
    }
}
