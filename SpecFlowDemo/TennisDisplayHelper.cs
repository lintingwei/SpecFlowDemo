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
            if (playerAScore > 0) {
                return $"{ScoreMapping[playerAScore]} {ScoreMapping[playerBScore]}";
            }
            return "Love All";
        }
    }
}
