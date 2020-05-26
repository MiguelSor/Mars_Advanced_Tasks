Feature: NotificationDelete
		In order to test delete notification button
		As a test analyst
		I want to automate user interactions with the delete notification button

@mytag
Scenario: Checkbox should be visible
	Given I login to the website
	And I click on the dashboard
	Then the checkbox should be visible

Scenario: UI menu should be visible
	Given I login to the website
	And I click on the dashboard
	When I click on the checkbox
	Then UI menu should be visible

Scenario: Delete button should be visible to the user
	Given I login to the website
	And I click on the dashboard
	When I click on the checkbox
	Then delete button should be visible 

Scenario: Delete button should be clickable
	Given I login to the website
	And I click on the dashboard
	When I click on the checkbox
	Then I should be able to click on the delete button
