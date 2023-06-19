Feature: MainNavigationMenu


@SmokeTest
Scenario: TC06 Check main menu Home category is functional
	Given I am on the home page
	Then HOME Menu link is working
	When I mouseover HOME Menu button
	Then HOME dropdown appears and All links are working


@SmokeTest
Scenario: TC07 Check main menu Apparel & Accessories category is functional
	Given I am on the home page
	Then APPAREL & ACCESSORIES Menu link is working
	When I mouseover APPAREL & ACCESSORIES Menu button
	Then APPAREL & ACCESSORIES dropdown appears and All links are working


@SmokeTest
Scenario: TC08 Check main menu Makeup category is functional
	Given I am on the home page
	Then MAKEUP Menu link is working
	When I mouseover MAKEUP Menu button
	Then MAKEUP dropdown appears and All links are working


@SmokeTest
Scenario: TC09 Check main menu Skincare category is functional
	Given I am on the home page
	Then SKINCARE Menu link is working
	When I mouseover SKINCARE Menu button
	Then SKINCARE dropdown appears and All links are working


@SmokeTest
Scenario: TC10 Check main menu Fragrance category is functional
	Given I am on the home page
	Then FRAGRANCE Menu link is working
	When I mouseover FRAGRANCE Menu button
	Then FRAGRANCE dropdown appears and All links are working


@InDev
Scenario: TC11 Check main menu Men category is functional
	Given I am on the home page
	Then MEN Menu link is working
	When I mouseover MEN Menu button
	Then MEN dropdown appears and All links are working
