Feature: NotificationsShowLess
	In order to test show less button
	As a test analyst
	I want to automate user interactions with the show less button

@mytag
Scenario: Check if show less is visible to the user
	Given I login to the website
	And I click on the dashboard
	When I click on load more button on notifications
	Then show less should be visible

Scenario: Check if user is able to click on show less
	Given I login to the website
	And I click on the dashboard
	When I click on load more button on notifications
	Then user should be able to click on show less button

Scenario: Check if there are less results shown in notifications 
	Given I login to the website
	And I click on the dashboard
	When I click on load more button on notifications
	Then show less button should not ne visible