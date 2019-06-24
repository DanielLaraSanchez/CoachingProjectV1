using System;
namespace Domain
{
    public class Score
    {
        public string PlayerName { get; set; }
        public int Points { get; set; }

        public Score(string playerName)
        {
            PlayerName = playerName;
            Points = 0;

        }
    }
}
