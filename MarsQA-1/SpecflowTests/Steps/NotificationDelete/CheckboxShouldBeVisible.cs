using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationDelete
{
    [Binding]
    public class CheckboxShouldBeVisible
    {
        [Then(@"the checkbox should be visible")]
        public void ThenTheCheckboxShouldBeVisible()
        {
            Dashboard.CheckboxShouldBeVisible();
        }
    }
}
