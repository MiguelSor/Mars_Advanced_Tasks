using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\migue\Downloads\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx","Credentials");
            //call the SignIn class
            SignIn.Login();
        }

        [AfterScenario]
        public void TearDown()
        {
            CommonMethods.ExtentReports();

            // Screenshot
           String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
           test = CommonMethods.Extent.StartTest("Steps Log Definition");
           test.Log(LogStatus.Info, "Snapshot below: " + img);
         
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            //CommonMethods.Extent.Flush();

            //Close the browser
            Close();


        }
    }
}
