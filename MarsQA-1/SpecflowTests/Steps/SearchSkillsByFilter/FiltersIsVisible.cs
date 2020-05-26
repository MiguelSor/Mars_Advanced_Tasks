using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SearchSkillsByFilterSteps
    {
        [Given(@"I clicked on programming and tech")]
        public void GivenIClickedOnProgrammingAndTech()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//a[@href='/Home/Search?cat=ProgrammingTech'][contains(.,'Programming Tech')]")).Click();
        }
        
        [When(@"scroll down to the filters")]
        public void WhenScrollDownToTheFilters()
        {
            var element = Driver.driver.FindElement(By.XPath("(//div[contains(.,'Filter')])[8]"));
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element);
            action.Perform();
        }
        
        [Then(@"filters should be visible to the user")]
        public void ThenFiltersShouldBeVisibleToTheUser()
        {
            Driver.TurnOnWait();
        }
    }
}
