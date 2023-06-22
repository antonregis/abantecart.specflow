Feature: SocialMedia


@SmokeTest
Scenario: TC06A. Check Header Social Media links are working
	Given I am on the home page
	Then Facebook header link is correct and working
	Then Twitter header link is correct and working


@SmokeTest
Scenario: TC06B. Check Footer Social Media links are working
	Given I am on the home page
	Then Facebook footer link is correct and working
	Then Twitter footer link is correct and working
