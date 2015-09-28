
using Calculator.Tests.Support;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Calculator.Tests.PageObjects
{
    class PageObjectFactory
    {
        public static CalculatorPage CalculatorPage
        {
            get { return CreatePage<CalculatorPage>(); }
        }

        private static T CreatePage<T>()
        {
            var page = (T)Activator.CreateInstance(typeof(T), SeleniumSupport.WebBrowser);
            PageFactory.InitElements(SeleniumSupport.WebBrowser, page);
            return page;
        }
    }
}
