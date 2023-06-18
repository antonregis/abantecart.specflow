Feature: MainNavigationMenu


@SmokeTest
Scenario: Check main menu Home category is functional
	Given I am on the home page
	Then HOME Menu link is working
	When I mouseover HOME Menu button
	Then All links in the HOME Menu dropdown are working
