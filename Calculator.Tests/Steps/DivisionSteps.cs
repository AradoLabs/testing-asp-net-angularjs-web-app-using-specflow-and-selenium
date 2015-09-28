using Calculator.Tests.PageObjects;
using Calculator.Tests.Support.Features;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class DivisionSteps
    {
        [Given(@"I have selected the division operation in the calculator")]
        public void GivenIHaveSelectedTheDivisionOperationInTheCalculator()
        {
            CalculatorPage.SelectDivisionOperation();
        }
                
        private CalculatorPage CalculatorPage
        {
            get { return CalculatorFeatureSupport.CalculatorPage; }
        }
    }
}
