using SpecFlowDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class CalculatorSteps
    {
        private ScenarioContext _scenarioContext;
        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _scenarioContext.Set<int>(firstNumber, "firstNumber");
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _scenarioContext.Set<int>(secondNumber, "secondNumber");
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            _scenarioContext.Pending();
        }
    }
}
