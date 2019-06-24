using System;
using System.Collections.Generic;
using Domain.Interfaces;


//IEnumerable, List, Array? why can i not use linq to order by with list. what is the difference between all of them?
//what is the weird using in emailsender doing?



namespace Domain
{
    public class Ranking : IRanking
    {
        private readonly List<Score> _scores;

        public Ranking()
        {
           _scores = new List<Score>();
        }

        public IEnumerable<Score> CalculateScores(List<Game> games)
        {
            if (games == null)
            {
                throw new ArgumentNullException("Please enter a List of games");
            }
            InsertAllPlayerNamesInScoresArray(games);
            
            foreach (Game game in games)
            {
                ApplyActionOnPlayersAfterGame(game);
            }

            _scores.Sort((a, b) => b.Points.CompareTo(a.Points));
            return _scores;
        }

        public int GetScores()
        {
            return _scores.Count;
        }

        private void ApplyActionOnPlayersAfterGame(Game game)
        {
            if (game == null)
            {
                throw new ArgumentNullException("Please enter a game");
            }
            if(_scores.Count > 0)
            {
                foreach(Score score in _scores)
                {
                    ActionOnWinnerAfterGame(game, score);
                }
            }
        }

        public void ActionOnWinnerAfterGame(Game game, Score score)
        {
            if(score.PlayerName == game.Winner.Name && game.IsConfirmed)
            {
                score.Points += 1;
            }
        }

   

        public void InsertAllPlayerNamesInScoresArray(List<Game> games)
        {
            var arrayNames = GetAllPlayerNames(games);

            foreach(string name in arrayNames)
            {
                Score score = new Score(name);
                _scores.Add(score);
            }
        }



       public IEnumerable<string> GetAllPlayerNames(List<Game> games)
        {
            var arrayNames = new List<string>();
            foreach (Game game in games)
            {
                if (!arrayNames.Contains(game.Player1.Name))
                {
                    arrayNames.Add(game.Player1.Name);

                }
                if (!arrayNames.Contains(game.Player2.Name))
                {
                    arrayNames.Add(game.Player2.Name);
                }
            }

            return arrayNames;
        }


    }


    }

   
