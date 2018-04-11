using HomeCollection.Data;
using HomeCollection.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeCollection.Http
{
    public class ApiHelper
    {
        private WebClient webClient = new WebClient();
        //private string baseUri = "http://www.boardgamegeek.com/";

        public event EventHandler<ApiRequestEventArgs> SearchFinished;

        public ApiHelper()
        {            
            webClient.DownloadStringCompleted += OnDownloadCompleted;
        }
        
        public void Request(Uri uri)
        {                        
            webClient.DownloadStringAsync(uri);
        }
        
        private void OnDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XDocument document = XDocument.Parse(e.Result);

            if (SearchFinished != null)
                SearchFinished(this, new ApiRequestEventArgs(document));
        }
    }
}
