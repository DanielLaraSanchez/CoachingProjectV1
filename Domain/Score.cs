﻿using System;
namespace Domain
{
    public class Score
    {
        public string Player { get; set; }
        public int Points { get; set; }

        public Score(string player)
        {
            Player = player;
        }
    }
}
