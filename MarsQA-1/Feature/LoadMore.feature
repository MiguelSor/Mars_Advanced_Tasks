Feature: LoadMore
	In order to test load More button
	As a test analyst
	I want to automate user interactions with the Load More Button

@mytag
Scenario: Load more should be visible
	Given I login to the website
	And I click on the dashboard
	Then load more button should be visible

Scenario: Load more should be clickable
	Given I login to the website
	And I click on the dashboard
	Then load more button should be clickable

Scenario: Notifications have more results after clicking load more
	Given I login to the website
	And I click on the dashboard
	When I click on load more button
	Then there should be more results


