using System.Collections.Generic;


//how can i make a method be able to return 2 different things. if there is an IF statement?
//IEnumerable, List, Array? why can i not use linq to order by with list. what is the difference between all of them?
//how to do it so that only a particular class can change the properties of another class. 

namespace Domain
{
    public class Ranking
    {
        public List<Score> scores = new List<Score>();

        public IEnumerable<Score> CalculateScores(List<Game> games)
        {
            insertAllPlayerNamesInScoresArray(games);

            foreach (Game game in games)
            {
                applyActionOnPlayersAfterGame(game);
            }

            scores.Sort((a, b) => b.Points.CompareTo(a.Points));

            return scores;
        }

        


        public void applyActionOnPlayersAfterGame(Game game)
        {
            foreach(Score score in scores)
            {
                actionOnWinnerAfterGame(game, score);
            }

        }

        public void actionOnWinnerAfterGame(Game game, Score score)
        {
            if(score.Player == game.Winner.Name && game.IsConfirmed == true)
            {
                score.Points += 1;
            }
        }

   

        public void insertAllPlayerNamesInScoresArray(List<Game> games)
        {
            var arrayNames = getAllPlayerNames(games);

            foreach(string name in arrayNames)
            {
                Score score = new Score(name);
                score.Points = 0;
                scores.Add(score);
            }
        }



        public IEnumerable<string> getAllPlayerNames(List<Game> games)
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

   
