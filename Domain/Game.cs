using System;


namespace Domain
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        public Player Looser { get; set; }
        public Boolean IsConfirmed { get; internal set; }
        public DateTime TimeStamp { get; }
        public Player Creator { get; set; }



        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            TimeStamp = DateTime.Now;
        }


    }

   
}
