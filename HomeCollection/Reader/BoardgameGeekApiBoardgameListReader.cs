using HomeCollection.Data;
using HomeCollection.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeCollection.Reader
{
    public class BoardgameGeekApiBoardgameListReader
    {
        public BoardgameGeekApiBoardgameListReader()
        {

        }

        public List<BoardgameGeekApiResult> FromXml(XDocument document)
        {

            List<BoardgameGeekApiResult> result = new List<BoardgameGeekApiResult>();
            foreach (XElement game in document.Descendants("boardgame"))
            {
                XAttribute idAttribute = game.Attribute("objectid");
                int id = int.Parse(idAttribute.Value);

                XElement nameElement = game.Element("name");
                string name = "";
                if (nameElement != null)
                    name = nameElement.Value;

                XElement yearElement = game.Element("yearpublished");
                int year = 0;
                if (yearElement != null)
                    year = int.Parse(yearElement.Value);

                result.Add(new BoardgameGeekApiResult(id, name, year));
            }

            return result;
        }
    }
}
