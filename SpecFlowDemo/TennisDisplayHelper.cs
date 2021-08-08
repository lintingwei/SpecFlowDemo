using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public class TennisDisplayHelper
    {
        public static string GetDisplayScore(int playerAScore, int playerBScore)
        {
            if (playerAScore == 1) {
                return "Fifteen Love";
            }
            return "Love All";
        }
    }
}
