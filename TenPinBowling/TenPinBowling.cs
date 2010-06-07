using System;
using System.Collections.Generic;
using System.Linq;

namespace TenPinBowling
{
    public class TenPinBowling
    {
        private Dictionary<string, int> _scores;

        public TenPinBowling(string player1, string player2)
        {
            _scores = new Dictionary<string, int>();
            _scores.Add(player1, 0);
            _scores.Add(player2, 0);
        }
        
        public string GetScore()
        {
            return string.Format("{0}, {1}. {2}, {3}.",
                                 _scores.ElementAt(0).Key, _scores.ElementAt(0).Value,
                                 _scores.ElementAt(1).Key, _scores.ElementAt(1).Value);
        }

        public void ThrowBall(string player, int pinsKnockedDown)
        {
            int score = _scores[player];
            _scores[player] = (score + pinsKnockedDown);
        }
    }
}