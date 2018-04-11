using HomeCollection.Data;
using HomeCollection.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeCollection.Events
{
    public class BoardgameEventArgs
    {
        public Boardgame Boardgame { get; set; }

        public BoardgameEventArgs(Boardgame boardgame)
        {
            Boardgame = boardgame;
        }
    }
}
