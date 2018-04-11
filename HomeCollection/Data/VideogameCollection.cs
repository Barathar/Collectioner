using System;
using System.Collections.Generic;

namespace HomeCollection.Data
{
    [Serializable]
    public class VideogameCollection
    {
        public List<Videogame> Videogames { get; set; }

        public VideogameCollection()
        {
            Videogames = new List<Videogame>();
        }
    }
}
