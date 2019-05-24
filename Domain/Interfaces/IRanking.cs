using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IRanking
    {
        IEnumerable<Score> CalculateScores(List<Game> games);
    }
}
