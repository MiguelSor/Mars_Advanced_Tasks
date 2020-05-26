using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationDelete
{
    [Binding]
    public class DeleteButtonShouldBeVisible
    {
        [Then(@"delete button should be visible")]
        public void ThenDeleteButtonShouldBeVisible()
        {
            Dashboard.DeleteButtonShouldBeVisible();
        }
    }
}
