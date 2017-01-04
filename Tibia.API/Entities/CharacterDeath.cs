using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;

namespace Tibia.API.Entities
{
    internal class CharacterDeath : ICharacterDeath
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
