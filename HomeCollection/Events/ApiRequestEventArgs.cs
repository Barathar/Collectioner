using System.Xml.Linq;

namespace HomeCollection.Events
{
    public class ApiRequestEventArgs
    {
        public XDocument Document { get; private set; }

        public ApiRequestEventArgs(XDocument document)
        {
            Document = document;
        }
    }
}
