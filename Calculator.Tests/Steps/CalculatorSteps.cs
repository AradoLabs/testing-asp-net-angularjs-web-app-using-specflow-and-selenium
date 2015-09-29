using Calculator.Tests.PageObjects;
using Calculator.Tests.Support.Features;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"Calculator is started")]
        public void GivenCalculatorIsStarted()
        {
            CalculatorPage.NavigateTo();
        }

        [Given(@"I have entered (.*) and (.*) into the calculator")]
        public void GivenIHaveGivenAndIntoTheCalculator(string firstInput, string secondInput)
        {
            CalculatorPage.TypeFirstInput(firstInput).TypeSecondInput(secondInput);
        }

        [When(@"I calculate")]
        public void WhenICalculate()
        {
            CalculatorPage.Calculate();
        }

        [Then(@"I should see following result: (.*)")]
        public void ThenIShouldSeeFollowingResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, CalculatorPage.ResultText);
        }

        [Then(@"I should not be able to calculate")]
        public void ThenIShouldNotBeAbleToCalculate()
        {
            Assert.IsFalse(CalculatorPage.CalculationCanBeDone);
        }

        private CalculatorPage CalculatorPage
        {
            get { return CalculatorFeatureSupport.CalculatorPage; }
        }
    }
}
