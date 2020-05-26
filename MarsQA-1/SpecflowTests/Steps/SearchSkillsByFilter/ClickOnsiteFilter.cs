using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class SearchSkillsByFilterSteps
    {
        [When(@"I scroll down to filters")]
        public void WhenIScrollDownToFilters()
        {
            var element = Driver.driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'Onsite')]"));
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element);
            action.Perform();
        }
        
        [Then(@"I click on Onsite filter")]
        public void ThenIClickOnOnsiteFilter()
        {
            SearchSkillPage.ClickOnSiteBtn();
        }
    }
}
