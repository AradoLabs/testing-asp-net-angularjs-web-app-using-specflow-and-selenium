using Calculator.Tests.PageObjects;
using Calculator.Tests.Support.Features;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class MultiplicationSteps
    {
        [Given(@"I have selected the multiplication operation in the calculator")]
        public void GivenIHaveSelectedTheMultiplicationOperationInTheCalculator()
        {
            CalculatorPage.SelectMultiplicationOperation();
        }


        private CalculatorPage CalculatorPage
        {
            get { return CalculatorFeatureSupport.CalculatorPage; }
        }
    }
}
