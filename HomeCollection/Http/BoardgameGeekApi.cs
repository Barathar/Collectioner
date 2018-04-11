using HomeCollection.Data;
using HomeCollection.Events;
using HomeCollection.Reader;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HomeCollection.Http
{
    public class BoardgameGeekApi
    {
        bool first = true;
        ApiHelper api = new ApiHelper();
        BoardgameGeekApiBoardgameReader boardgameReader = new BoardgameGeekApiBoardgameReader();
        BoardgameGeekApiBoardgameListReader searchResultReader = new BoardgameGeekApiBoardgameListReader();

        public event EventHandler<BoardgameEventArgs> RequestBoardgameCompleted;
        public event EventHandler<BoardgameSearchEventArgs> RequestBoardgameSearchCompleted;

        public BoardgameGeekApi()
        {
            api.SearchFinished += OnApiSearchFinished;
        }

        private void OnApiSearchFinished(object sender, ApiRequestEventArgs e)
        {
            //improve this by detecting the right search
            XDocument document = e.Document;
            if (first)
                NotifyRequestBoardgameSearchCompleted(document);
            else
                NotifyRequestBoardgameCompleted(document);

            first = false;
        }

        public void RequestBoardgame(int id)
        {
            string query = string.Format("http://www.boardgamegeek.com/xmlapi/boardgame/{0}", id);
            Uri uri = new Uri(query);
            api.Request(uri);
        }
        public void RequestBoardgameSearch(string name)
        {
            string query = string.Format("http://www.boardgamegeek.com/xmlapi/search?search={0}", name);
            Uri uri = new Uri(query);
            api.Request(uri);
        }
        
        private void NotifyRequestBoardgameCompleted(XDocument document)
        {
            Boardgame boardgame = boardgameReader.FromXml(document);

            if (RequestBoardgameCompleted != null)
                RequestBoardgameCompleted(this, new BoardgameEventArgs(boardgame));
        }
        private void NotifyRequestBoardgameSearchCompleted(XDocument document)
        {
            List<BoardgameGeekApiResult> boardgames = searchResultReader.FromXml(document);

            if (RequestBoardgameSearchCompleted != null)
                RequestBoardgameSearchCompleted(this, new BoardgameSearchEventArgs(boardgames));
        }
    }
}
