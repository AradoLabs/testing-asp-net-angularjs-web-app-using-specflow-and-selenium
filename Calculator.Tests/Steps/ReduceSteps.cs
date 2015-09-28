using Calculator.Tests.PageObjects;
using Calculator.Tests.Support.Features;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class ReduceSteps
    {
        [Given(@"I have selected the reduce operation in the calculator")]
        public void GivenIHaveSelectedTheReduceOperationInTheCalculator()
        {
            CalculatorPage.SelectReduceOperation();
        }
        
        private CalculatorPage CalculatorPage
        {
            get { return CalculatorFeatureSupport.CalculatorPage; }
        }
    }
}
