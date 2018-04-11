using System;
using System.Collections.Generic;

namespace HomeCollection.Data
{
    [Serializable]
    public class BoardgameCollection
    {
        public List<Boardgame> Boardgames { get; set; }

        public BoardgameCollection()
        {
            Boardgames = new List<Boardgame>();
        }
    }
}
