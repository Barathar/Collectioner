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
    public class BoardgameSearchEventArgs
    {
        public List<BoardgameGeekApiResult> Result { get; set; }

        public BoardgameSearchEventArgs(List<BoardgameGeekApiResult> result)
        {
            Result = result;
        }
    }
}
