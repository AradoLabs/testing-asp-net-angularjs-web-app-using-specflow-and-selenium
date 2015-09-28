using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Support
{
    [Binding]
    public static class IISExpressSupport
    {
        private static Process _iisExpressProcess;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            StartIISExpress();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            StopIISExpress();
        }

        private static void StartIISExpress()
        {
            var arguments = string.Format(
                CultureInfo.InvariantCulture,
                "/path:\"{0}\" /port:{1}", CalculatorPath, ApplicationSettings.UriOfCalculator.Port);

            var startInfo = new ProcessStartInfo(ApplicationSettings.IISExpressPath)
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                ErrorDialog = true,
                LoadUserProfile = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                Arguments = arguments
            };

            _iisExpressProcess = Process.Start(startInfo);
        }

        private static void StopIISExpress()
        {
            if (_iisExpressProcess.HasExited == false)
            {
                _iisExpressProcess.Kill();
                _iisExpressProcess.Dispose();
                _iisExpressProcess = null;
            }
        }

        private static string CalculatorPath
        {
            get
            {
                var solutionFolder = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));

                return Path.Combine(solutionFolder, ApplicationSettings.CalculatorPath);
            }
        }
    }
}
