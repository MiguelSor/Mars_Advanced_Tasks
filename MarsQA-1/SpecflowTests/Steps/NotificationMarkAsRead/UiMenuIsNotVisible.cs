using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationMarkAsRead
{
    [Binding]
    public class UiMenuIsNotVisible
    {
        [When(@"checkbox is unchecked")]
        public void WhenCheckboxIsUnchecked()
        {
            Dashboard.CheckboxIsUnchecked();
        }
        
        [Then(@"UI menu is not visible")]
        public void ThenUIMenuIsNotVisible()
        {
            Dashboard.UiMenuIsNotVisible();
        }
    }
}
