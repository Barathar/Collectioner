using HomeCollection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using System.Net;
using System.IO;
using HomeCollection.Utility;

namespace HomeCollection.Reader
{
    public class BoardgameGeekApiBoardgameReader
    {
        public BoardgameGeekApiBoardgameReader()
        {

        }

        public Boardgame FromXml(XDocument document)
        {
            XElement boardgame = document.Root.Elements("boardgame")?.First();
            if (boardgame == null)
                return null;

            Boardgame result = new Boardgame();
            result.Titles = ReadTitles(boardgame);
            result.Description = ReadDescription(boardgame);
            result.YearPublished = ReadYearPublished(boardgame);
            result.Tags = ReadCategory(boardgame);
            result.Image = ReadImage(boardgame);            
            result.PreviewImage = ReadPreviewImage(boardgame);
            // TODO keep on reading...
            // ... also refactor me!

            return result;
        }

        private List<string> ReadTitles(XElement boardgame)
        {
            return boardgame.Descendants("name")?.Select(e => e.Value)?.ToList();
        }
        private string ReadDescription(XElement boardgame)
        {
            return boardgame.Descendants("description").First().Value;
        }
        private int ReadYearPublished(XElement boardgame)
        {
            return int.Parse(boardgame.Descendants("yearpublished").First().Value);
        }
        private List<string> ReadCategory(XElement boardgame)
        {
            return boardgame.Descendants("boardgamecategory").Select(e => e.Value).ToList();
        }
        private Image ReadImage(XElement boardgame)
        {
            IEnumerable<XElement> elements = boardgame.Elements("image");
            if (elements.Count() <= 0)
                return null;
            
            string url = elements.First().Value;
            if (string.IsNullOrWhiteSpace(url))
                return null;

            return GetImageFromURL(url);
        }
        private Image ReadPreviewImage(XElement boardgame)
        {            
            IEnumerable<XElement> elements = boardgame.Elements("thumbnail");
            if (elements.Count() <= 0)
                return null;

            string url = elements.First().Value;
            if (string.IsNullOrWhiteSpace(url))
                return null;

            return GetImageFromURL(url);
        }

        private static Image GetImageFromURL(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = httpWebReponse.GetResponseStream();
            return Image.FromStream(stream);
        }
    }
}
