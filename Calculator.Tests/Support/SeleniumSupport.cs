using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Support
{
    [Binding]
    public static class SeleniumSupport
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var service = PhantomJSDriverService.CreateDefaultService();
            WebBrowser = new PhantomJSDriver(service);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (WebBrowser != null)
            {
                WebBrowser.Dispose(); //dispose will run Quit() automatically for the driver
                WebBrowser = null;
            }
        }

        public static IWebDriver WebBrowser { get; private set; }
    }
}
