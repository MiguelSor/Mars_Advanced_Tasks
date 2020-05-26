using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.NotificationDelete
{
    [Binding]
    public class DeleteButtonShouldBeClickable
    {
        [Then(@"I should be able to click on the delete button")]
        public void ThenIShouldBeAbleToClickOnTheDeleteButton()
        {
            Dashboard.DeleteButtonShouldBeClickable();
        }
    }
}
