using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Scoreboard
    {

        private List<(string PlayerName, double Score)> scores;

        public Scoreboard()
        {
            scores = new List<(string PlayerName, double Score)>();
        }

        public void AddScore(string playerName, double score)
        {
            scores.Add((playerName, score));
            scores = scores.OrderByDescending(s => s.Score).Take(10).ToList();
        }

        public List<(string PlayerName, double Score)> GetTopScores()
        {
            return scores;
        }

    }
}
