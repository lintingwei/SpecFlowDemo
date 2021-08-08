using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public class TennisDisplayHelper
    {
        private static readonly Dictionary<int, string> ScoreMapping = new Dictionary<int, string>() { { 0, "Love" }, { 1, "Fifteen" }, { 2, "Thirty" }, { 3, "Forty" } };
        public static string GetDisplayScore(int playerAScore, int playerBScore)
        {
            if (playerAScore > playerBScore && playerAScore > 2 && playerBScore > 2) {
                return "Player A Adv";
            }
            if (IsDeuce(playerAScore, playerBScore))
            {
                return "Deuce";
            }
            if (SameScore(playerAScore, playerBScore))
            {
                return $"{ScoreMapping[playerAScore]} All";
            }
            return $"{ScoreMapping[playerAScore]} {ScoreMapping[playerBScore]}";
        }

        private static bool IsDeuce(int playerAScore, int playerBScore)
        {
            return SameScore(playerAScore, playerBScore) && playerAScore > 2;
        }

        private static bool SameScore(int playerAScore, int playerBScore)
        {
            return playerAScore == playerBScore;
        }
    }
}
