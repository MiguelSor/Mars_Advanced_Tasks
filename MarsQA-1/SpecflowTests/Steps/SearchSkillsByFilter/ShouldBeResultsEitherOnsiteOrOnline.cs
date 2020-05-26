using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.SearchSkillsByFilter
{
    [Binding]
    public class ShouldBeResultsEitherOnsiteOrOnline
    {
        [When(@"I click on show all filter and the first result")]
        public void WhenIClickOnShowAllFilterAndTheFirstResult()
        {
            //Click on show all button
            SearchSkillPage.ClickShowAllBtn();
            //wait for the elements to load
            Driver.TurnOnWait();
            //click on the first results
            SearchSkillPage.ClickResultBtn();
        }
        
        [Then(@"the location type should be either onsite or online")]
        public void ThenTheLocationTypeShouldBeEitherOnsiteOrOnline()
        {
            //wait for the elements to load
            Driver.TurnOnWait();
            //Checks if location type is onsite or online
            ServiceDetail.LocationEither();
        }
    }
}
