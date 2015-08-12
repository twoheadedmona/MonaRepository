using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameList.Core.Entities
{
    public class Studio : Base
    {
        public List<Game> MadeGames { get; set; }
    }
}
