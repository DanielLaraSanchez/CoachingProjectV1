using System.Collections.Generic;
using Domain.Interfaces;


//IEnumerable, List, Array? why can i not use linq to order by with list. what is the difference between all of them?
//what is the weird using in emailsender doing?



namespace Domain
{
    public class Ranking : IRanking
    {
        public List<Score> scores = new List<Score>();

        public IEnumerable<Score> CalculateScores(List<Game> games)
        {
            InsertAllPlayerNamesInScoresArray(games);

            foreach (Game game in games)
            {
                ApplyActionOnPlayersAfterGame(game);
            }

            scores.Sort((a, b) => b.Points.CompareTo(a.Points));
            return scores;
        }

        public void ApplyActionOnPlayersAfterGame(Game game)
        {
            foreach(Score score in scores)
            {
                ActionOnWinnerAfterGame(game, score);
            }

        }

        public void ActionOnWinnerAfterGame(Game game, Score score)
        {
            if(score.Player == game.Winner.Name && game.IsConfirmed == true)
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
                score.Points = 0;
                scores.Add(score);
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

   
