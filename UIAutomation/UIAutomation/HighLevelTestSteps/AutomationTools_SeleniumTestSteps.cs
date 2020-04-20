using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.PageObjectsAndActions;
using UIAutomation.Utilities;

namespace UIAutomation.HighLevelTestSteps
{
    class AutomationTools_SeleniumTestSteps
    {
        public static void VerifySeleniumWebDriver()
        {
            string header = "Selenium WebDriver ";
            MainMenuNavigation.SelectAutomationTools_Function(MainMenuNavigation.AutomationTools_Navigation.Selenium, MainMenuNavigation.Selenium_Navigation.SeleniumWebDriver);
            Assert.IsTrue(AutomationTools_Selenium.VerifyHeader(header), "Header is invalid");
        }

        public static void VerifySeleniumRC()
        {
            string header = "Selenium RC";
            MainMenuNavigation.SelectAutomationTools_Function(MainMenuNavigation.AutomationTools_Navigation.Selenium, MainMenuNavigation.Selenium_Navigation.SeleniumRC);
            Assert.IsTrue(AutomationTools_Selenium.VerifyHeader(header), "Header is invalid");
        }
    }
}
