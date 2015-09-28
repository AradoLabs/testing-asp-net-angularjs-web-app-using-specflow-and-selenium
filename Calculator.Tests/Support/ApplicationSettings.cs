using System;
using System.Configuration;

namespace Calculator.Tests.Support
{
    public class ApplicationSettings
    {
        public static Uri UriOfCalculator
        {
            get { return new Uri(ConfigurationManager.AppSettings[_appKeyUrlOfCalculator]); }
        }

        public static string CalculatorPath
        {
            get { return ConfigurationManager.AppSettings[_appKeyCalculator]; }
        }

        public static string IISExpressPath
        {
            get { return ConfigurationManager.AppSettings[_appKeyIISExpressPath]; }
        }

        private static string _appKeyUrlOfCalculator = "UrlOfCalculator";
        private static string _appKeyIISExpressPath = "IISExpressPath";
        private static string _appKeyCalculator = "CalculatorPath";
    }
}
