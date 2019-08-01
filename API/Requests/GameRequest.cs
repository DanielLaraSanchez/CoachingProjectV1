using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace API.Requests
{
    public class GameRequest
    {

        public  Player Player1 { get; set; }
        public  Player Player2 { get; set; }
        public  Player Winner { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreationTimeStamp { get; }
        public Player Creator { get; set; }

    }
}
