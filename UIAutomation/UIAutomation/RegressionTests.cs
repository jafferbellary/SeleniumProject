using log4net;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.HighLevelTestSteps;
using UIAutomation.Utilities;

namespace UIAutomation
{
    [TestFixture]
    class RegressionTests
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [OneTimeSetUp]
        public static void setup()
        {
            ExtentReport.BeforeClass();
            CommonOperations.TestFixturesetup();
        }

        [OneTimeTearDown]
        public static void teardown()
        {
            ExtentReport.AfterClass();
            CommonOperations.TestFixtureteardown1();
        }

        [SetUp]
        public static void testSetup()
        {
            ExtentReport.BeforeTest();
            CommonOperations.testsetup();
        }

        [TearDown]
        public static void testTeardown()
        {
            ExtentReport.AfterTest();
            CommonOperations.TestTeardown();
        }

        [Test, Category("Automation Tools: Selenium")]
        public static void _01_SeleniumWebDriverVerification()
        {
            log.Info("Executing Test");
            ReportResultUtility.InitializeReportString("_01_SeleniumWebDriverVerification");
            AutomationTools_SeleniumTestSteps.VerifySeleniumWebDriver();
            ReportResultUtility.CreateReport(ReportResultUtility.reportResultHtmlString.ToString(), Globalclass.resultlocation);
        }

        [Test, Category("Automation Tools: Selenium")]
        public static void _02_SeleniumRCVerification()
        {
            log.Info("Executing Test");
            ReportResultUtility.InitializeReportString("_02_SeleniumRCVerification");
            AutomationTools_SeleniumTestSteps.VerifySeleniumRC();
            ReportResultUtility.CreateReport(ReportResultUtility.reportResultHtmlString.ToString(), Globalclass.resultlocation);
        }
    }
}
