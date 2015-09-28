using Calculator.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Support.Features
{
    class CalculatorFeatureSupport
    {
        public static CalculatorPage CalculatorPage
        {
            get 
            {
                if(!ScenarioContext.Current.ContainsKey(_calculatorPageKey))
                {
                    ScenarioContext.Current.Add(_calculatorPageKey, PageObjectFactory.CalculatorPage);
                }
                return (CalculatorPage)ScenarioContext.Current[_calculatorPageKey]; 
            }
        }

        private const string _calculatorPageKey = "calculatorPage";
    }
}
