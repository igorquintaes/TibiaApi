using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using Tibia.API.Entities;
using Tibia.API.Entities.Contracts;
using Tibia.API.Enums;
using Tibia.API.Exceptions;
using Tibia.API.ObjectValues;
using Tibia.API.Services.Contracts;

namespace Tibia.API.Services
{
    public class RequestService : IRequestService
    {
        private readonly IConvertService _convertService;

        public RequestService (IConvertService convertService)
        {
            _convertService = convertService;
        }

        public IEnumerable<IGuild> GetAllGuilds(string world)
        {
            throw new NotImplementedException();
        }

        public ICharacter GetCharacterInformation(string characterName)
        {
            throw new NotImplementedException();
        }

        public IGuild GetGuildInformation(string guildName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICharacter> GetOnlineCharacters(string world)
        {
            if (String.IsNullOrEmpty(world))
                throw new InvalidDataException("world var can't be null or empty.");

            var web = new HtmlWeb();
            var document = web.Load(Links.WorldPage + world);

            if (document.DocumentNode.Descendants().Any(x => x.InnerText.Contains((ErrorMessages.InvalidWorldName))))
                throw new InvalidWorldException("Invalid world: " + world);

            var nodes = document.DocumentNode.SelectNodes("//*[@id='worlds']//table//tr[@class != 'LabelH']").Where(x => x.Attributes["class"].Value == "Odd" || x.Attributes["class"].Value == "Even");

            var characters = new List<ICharacter>();
            foreach(var node in nodes)
            {
                var character = new Character();
                character.Name = GetHtmlString(node, "td[1]/a[last()]");
                character.Level = GetHtmlInt(node, "td[2]");
                character.Vocation = GetHtmlVocation(node, "td[3]");

                characters.Add(character);
            }

            return characters;
        }

        #region Helpers

        private string GetHtmlString(HtmlNode node, string xpath)
        {
            return HtmlEntity.DeEntitize(node.SelectNodes(xpath).First().InnerText);
        }

        private int GetHtmlInt(HtmlNode node, string xpath)
        {
            return Convert.ToInt32(GetHtmlString(node, xpath));
        }

        private Vocation GetHtmlVocation(HtmlNode node, string xpath)
        {
            return _convertService.ToVocation(GetHtmlString(node, xpath));
        }

        #endregion
    }
}
