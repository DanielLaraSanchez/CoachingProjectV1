using System.Collections.Generic;


//how can i make a method be able to return 2 different things. if there is an IF statement?

namespace Domain
{
    public class Ranking
    {
        public List<Score> scores = new List<Score>();

        public Ranking() { }

        public IEnumerable<Score> CalculateScores(List<Game> games)
        {
            insertAllPlayerNamesInScoresArray(scores, games);


            foreach (Game game in games)
            {
                applyActionOnPlayersAfterGame(game, scores);

            }
            return scores;
        }

   


        public void applyActionOnPlayersAfterGame(Game game, List<Score> scores)
        {
            foreach(Score score in scores)
            {
                actionOnWinnerAfterGame(game, score);


            }

        }

        public void actionOnWinnerAfterGame(Game game, Score score)
        {
            if(score.Player == game.Winner.Name)
            {
                score.Points += 1;
            }
        }

   

        public void insertAllPlayerNamesInScoresArray(List<Score> scores, List<Game> games)
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
                if (!arrayNames.Contains(game.Looser.Name))
                {
                    arrayNames.Add(game.Looser.Name);

                }
                if (!arrayNames.Contains(game.Winner.Name))
                {
                    arrayNames.Add(game.Winner.Name);
                }
            }

            return arrayNames;
        }


    }








    }

   
