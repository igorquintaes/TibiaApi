using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Tibia.API.Enums;

namespace Tibia.API.Services.Contracts
{
    public interface IConvertService
    {
        Vocation ToVocation(string value);

        
    }
}
