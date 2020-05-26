using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class SearchSkillPage
    {
        private static IWebElement OnlineBtn => Driver.driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'Online')]"));

        private static IWebElement OnsiteBtn => Driver.driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'Onsite')]"));

        private static IWebElement ShowAllBtn => Driver.driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'ShowAll')]"));

        private static IWebElement OnlineResultBtn => Driver.driver.FindElement(By.XPath("(//img[@src='http://mars-listing-photo.s3.amazonaws.com/18a85a80-e30e-4a1a-9341-7b6859c20908default-image.jpg'])[1]"));


        public static void ClickOnlineBtn()
        {
            Driver.TurnOnWait();
            OnlineBtn.Click();
            
        }

        public static void ClickOnSiteBtn()
        {
            Driver.TurnOnWait();
            OnsiteBtn.Click();
            
        }

        public static void ClickShowAllBtn()
        {
            Driver.TurnOnWait();
            ShowAllBtn.Click();
            
        }

        public static void ClickResultBtn()
        {
            Driver.TurnOnWait();
            OnlineResultBtn.Click();
            
        }

        public static void CheckProgrammingAndTechUrl()
        {
            //gets the actual Url from the browser
            String actualUrl = Driver.driver.Url;
            //expected Url of search skills page
            String expectedUrl = "http://192.168.99.100:5000/Home/Search?cat=ProgrammingTech";
            //Checks if both Url are the same
            Assert.That(expectedUrl, Is.EqualTo(actualUrl));
            Driver.TurnOnWait();
        }
    }

}
