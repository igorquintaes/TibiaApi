using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibia.API.Entities.Contracts;
using Tibia.API.Services;

namespace Tibia.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var convertService = new ConvertService();
            var requestService = new RequestService(convertService);

            var characters = requestService.GetOnlineCharacters("Luminera");
            //foreach (var character in characters)
            //{
            //    Console.WriteLine("Nome: " + character.Name + ", Nível: " + character.Level + ", Vocação: " + character.Vocation.ToString());
            //}
            
            var listCharacters = new List<ICharacter>();
            Parallel.ForEach(characters, (character) =>
            {
                var fullInfoCharacter = requestService.GetCharacterInformation(character);
                //var mortes = fullInfoCharacter.Deaths == null
                //    ? "Nenhuma morte"
                //    : String.Join("\n", fullInfoCharacter.Deaths.Select(x => x.Message));

                //Console.WriteLine("Nome: " + character.Name + "\n" + mortes);
                listCharacters.Add(fullInfoCharacter);
            });
            
            //died last 3 hours
            foreach (var character in listCharacters.Where(x => x.Deaths != null && x.Deaths.Any(y => (DateTime.Now - y.Date ).TotalMinutes <= 180)))
            {
                var lastDeaths = String.Join("\n", character.Deaths.Where(x => (DateTime.Now - x.Date).TotalMinutes <= 180).Select(x => x.Date.ToString("dd/MM/yyy HH:mm:ss") + " - " + x.Message));

                Console.WriteLine("Nome: " + character.Name + "\n" + lastDeaths);
            }

            Console.Read();
        }
    }
}
