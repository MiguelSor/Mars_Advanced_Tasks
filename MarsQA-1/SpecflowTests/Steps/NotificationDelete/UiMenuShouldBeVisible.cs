using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationDelete
{
    [Binding]
    public class UiMenuShouldBeVisible
    {
        [When(@"I click on the checkbox")]
        public void WhenIClickOnTheCheckbox()
        {
            Dashboard.CheckboxShouldBeClickable();
        }
        
        [Then(@"UI menu should be visible")]
        public void ThenUIMenuShouldBeVisible()
        {
            Dashboard.UIMenuShouldBeVisible();
        }
    }
}
