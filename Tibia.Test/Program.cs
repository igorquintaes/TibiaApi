using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (var character in characters)
            {
                Console.WriteLine("Nome: " + character.Name + ", Nível: " + character.Level + ", Vocação: " + character.Vocation.ToString());
            }

            Console.Read();
        }
    }
}
