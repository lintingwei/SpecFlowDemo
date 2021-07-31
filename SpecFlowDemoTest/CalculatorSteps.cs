﻿using NUnit.Framework;
using SpecFlowDemo;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator;
        private ScenarioContext _scenarioContext;
        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _calculator = new Calculator();
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

        [Given(@"the two numbers are (.*) and (.*)")]
        public void GivenTheTwoNumbersAre(int firstNumber, int secondNumber)
        {
            _scenarioContext.Set<int>(firstNumber, "firstNumber");
            _scenarioContext.Set<int>(secondNumber, "secondNumber");
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            var result = _calculator.Add(firstNumber, secondNumber);

            _scenarioContext.Set<int>(result, "result");
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            var result = _scenarioContext.Get<int>("result");
            Assert.AreEqual(expected, result);
        }
    }
}
