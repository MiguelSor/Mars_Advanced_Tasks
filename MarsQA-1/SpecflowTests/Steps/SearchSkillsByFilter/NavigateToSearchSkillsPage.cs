using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class NavigateToSearchSkillsPage
    {
        [When(@"I click on programming and tech")]
        public void WhenIClickOnProgrammingAndTech()
        {   
            //wait for the element to load
            Driver.TurnOnWait();
            //look and click on programming and tech category
            Driver.driver.FindElement(By.XPath("//a[@href='/Home/Search?cat=ProgrammingTech'][contains(.,'Programming Tech')]")).Click();
        }
        
        [Then(@"I am directed to search skills page")]
        public void ThenIAmDirectedToSearchSkillsPage()
        {
            //Checks if the Url is the same as search skill page
            SearchSkillPage.CheckProgrammingAndTechUrl();
            Driver.TurnOnWait();
        }
    }
}
