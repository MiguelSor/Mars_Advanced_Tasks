using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ServiceDetail
    {
        private static IWebElement OnlineLocation => Driver.driver.FindElement(By.XPath("//div[@class='description'][contains(.,'Online')]")); 

        private static IWebElement OnsiteLocation => Driver.driver.FindElement(By.XPath("//div[@class='description'][contains(.,'On-Site')]"));

        public static void LocationOnline()
        {
            //Compares that location type is Online
            String actualResultOnline = OnlineLocation.Text;
            String expectedResultOnline = "Online";
            Assert.AreEqual(actualResultOnline,expectedResultOnline);
            //scrolls down to the location type
            var element = Driver.driver.FindElement(By.XPath("//div[@class='header'][contains(.,'Skills Trade')]"));
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element);
            action.Perform();
            //wait for the screenshot to take place
            Thread.Sleep(1500);
        }

        public static void LocationOnsite()
        {
            //Compares that location type is On-Site
            String actualResultOnsite = OnsiteLocation.Text;
            String expectedResultOnsite = "On-Site";
            Assert.That(expectedResultOnsite,Is.EqualTo(actualResultOnsite));
            //scrolls down to the location type
            var element = Driver.driver.FindElement(By.XPath("//div[@class='header'][contains(.,'Skills Trade')]"));
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element);
            action.Perform();
            //wait for the screenshot to take place
            Thread.Sleep(1500);
        }

        public static void LocationEither()
        {
                //scrolls down to the location type
                var element = Driver.driver.FindElement(By.XPath("//div[@class='header'][contains(.,'Skills Trade')]"));
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(element);
                action.Perform();
                //wait for the screenshot to take place
                Thread.Sleep(1500);

        }
    }

}

