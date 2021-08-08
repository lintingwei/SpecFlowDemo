using NUnit.Framework;
using SpecFlowDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class TennisSteps
    {
        private ScenarioContext _scenarioContext;
        public TennisSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"playerA score (.*)")]
        public void GivenPlayerAScore(int playerAScore)
        {
            _scenarioContext.Set<int>(playerAScore, "playerAScore");
        }
        
        [Given(@"playerB score (.*)")]
        public void GivenPlayerBScore(int playerBScore)
        {
            _scenarioContext.Set<int>(playerBScore, "playerBScore");
        }
        
        [When(@"get tennis score display string")]
        public void WhenGetTennisScoreDisplayString()
        {
            var playerAScore = _scenarioContext.Get<int>("playerAScore");
            var playerBScore = _scenarioContext.Get<int>("playerBScore");
            var scoreDisplay = TennisDisplayHelper.GetDisplayScore(playerAScore, playerBScore);
            _scenarioContext.Set<string>(scoreDisplay, "scoreDisplay");
        }
        
        [Then(@"the score display should be (.*)")]
        public void ThenTheScoreDisplayShouldBeLoveAll(string exceptedDisplayScore)
        {
            var scoreDisplay = _scenarioContext.Get<string>("scoreDisplay");
            Assert.AreEqual(exceptedDisplayScore, scoreDisplay);
        }
    }
}
