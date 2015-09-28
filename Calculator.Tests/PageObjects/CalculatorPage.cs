
using Calculator.Tests.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.PageObjects
{
    class CalculatorPage
    {
        public CalculatorPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public CalculatorPage Calculate()
        {
            CalculateButton.Click();
            return this;
        }

        public CalculatorPage NavigateTo()
        {
            _driver.Navigate().GoToUrl(UrlOfCalculator);
            return this;
        }

        public CalculatorPage TypeFirstInput(string input)
        {
            FirstInput.SendKeys(input);
            return this;
        }

        public CalculatorPage TypeSecondInput(string input)
        {
            SecondInput.SendKeys(input);
            return this;
        }

        public CalculatorPage SelectAddOperation()
        {
            Operation.SelectByText("+");
            return this;
        }

        public CalculatorPage SelectReduceOperation()
        {
            Operation.SelectByText("-");
            return this;
        }

        public CalculatorPage SelectDivisionOperation()
        {
            Operation.SelectByText("/");
            return this;
        }

        public CalculatorPage SelectMultiplicationOperation()
        {
            Operation.SelectByText("*");
            return this;
        }

        public bool CalculationCanBeDone
        {
            get { return CalculateButton.Enabled; }
        }

        public string ResultText
        {
            get { return Result.Text; }
        }

        private string UrlOfCalculator
        {
            get { return string.Format("{0}/Calculator", ApplicationSettings.UriOfCalculator); }
        }

        private SelectElement Operation
        {
            get { return new SelectElement(OperationElement); }
        }

        [FindsBy(How = How.Id, Using = "operation")]
        private IWebElement OperationElement { get; set; }

        [FindsBy(How = How.Id, Using = "firstInput")]
        private IWebElement FirstInput { get; set; }

        [FindsBy(How = How.Id, Using = "secondInput")]
        private IWebElement SecondInput { get; set; }

        [FindsBy(How = How.Id, Using = "result")]
        private IWebElement Result { get; set; }

        [FindsBy(How = How.Id, Using = "calculate")]
        private IWebElement CalculateButton { get; set; }

        private readonly IWebDriver _driver;
    }
}
