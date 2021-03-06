﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Tibia.API.Enums;
using Tibia.API.Services.Contracts;

namespace Tibia.API.Services
{
    public class ConvertService : IConvertService
    {
        public AccountStatus ToAccountStatus(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(value);

            var valueToCompare = value.ToLower();

            switch (valueToCompare)
            {
                case "free account":
                    return AccountStatus.Free;
                case "free":
                    return AccountStatus.Free;
                case "premium account":
                    return AccountStatus.Premium;
                case "premium":
                    return AccountStatus.Premium;
                default:
                    throw new InvalidCastException("Value " + value + " is not a valid account status.");
            }
        }

        public string ToCharacterNameLink(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(value);

            // space, apostrophe
            return value
                .Replace(" ", "+")
                .Replace("'", "%27");
        }

        public Sex ToSex(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(value);

            var valueToCompare = value.ToLower();

            switch (valueToCompare)
            {
                case "male":
                    return Sex.Male;
                case "female":
                    return Sex.Female;
                default:
                    throw new InvalidCastException("Value " + value + " is not a valid sex.");
            }
        }

        public Vocation ToVocation(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(value);

            var valueToCompare = value.ToLower();

            switch (valueToCompare)
            {
                case "none":
                    return Vocation.None;
                case "sorcerer":
                    return Vocation.Sorcerer;
                case "druid":
                    return Vocation.Druid;
                case "paladin":
                    return Vocation.Paladin;
                case "knight":
                    return Vocation.Knight;
                case "master sorcerer":
                    return Vocation.MasterSorcerer;
                case "elder druid":
                    return Vocation.ElderDruid;
                case "royal paladin":
                    return Vocation.RoyalPaladin;
                case "elite knight":
                    return Vocation.EliteKnight;
                default:
                    throw new InvalidCastException("Value " + value + " is not a valid vocation.");
            }
        }

        
    }
}
