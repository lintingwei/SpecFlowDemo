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
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"playerB score (.*)")]
        public void GivenPlayerBScore(int playerBScore)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get tennis score display string")]
        public void WhenGetTennisScoreDisplayString()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the score display should be (.*)")]
        public void ThenTheScoreDisplayShouldBeLoveAll(string displayScore)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
