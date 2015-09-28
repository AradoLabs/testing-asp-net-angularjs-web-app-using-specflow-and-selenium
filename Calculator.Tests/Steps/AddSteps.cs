using Calculator.Tests.PageObjects;
using Calculator.Tests.Support.Features;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class AddSteps
    {
        [Given(@"I have selected the add operation in the calculator")]
        public void GivenIHaveSelectedTheAddOperationInTheCalculator()
        {
            CalculatorPage.SelectAddOperation();
        }

        private CalculatorPage CalculatorPage
        {
            get { return CalculatorFeatureSupport.CalculatorPage; }
        }
    }
}
