using log4net;
using NUnitLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.Utilities;

namespace UIAutomation
{
    class Dummy
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //static void Main(string[] args)
        //{
        //    ExtentReport.BeforeClass();
        //    CommonOperations.TestFixturesetup();

        //    ExtentReport.BeforeTest();
        //    RegressionTests._02_SeleniumRCVerification();
        //    ExtentReport.AfterTest();

        //    CommonOperations.TestFixtureteardown();
        //    ExtentReport.AfterClass();

        //    //int i = 10;
        //    //int j = 0;
        //    //try
        //    //{
        //    //    int k=i / j;
        //    //}
        //    //catch(Exception e)
        //    //{
        //    //    log.Info("Failed");
        //    //    log.Info(e.Message);
        //    //}
        //}

        //Execute Automation Scripts from Command Prompt
        static int Main(string[] args)
        {
            return new AutoRun().Execute(args);
        }
    }
}
