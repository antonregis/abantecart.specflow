Feature: MainNavigationMenu


@SmokeTest
Scenario: TC06 Check main menu Home category is functional
	Given I am on the home page
	Then HOME Menu link is working
	When I mouseover HOME Menu button
	Then All links in the HOME Menu dropdown are working


@InDevelopment
Scenario: TC07 Check main menu Apparel & Accessories category is functional
	Given I am on the home page
	Then APPAREL & ACCESSORIES Menu link is working
	When I mouseover APPAREL & ACCESSORIES Menu button
	Then APPAREL & ACCESSORIES dropdown appears and All links are working