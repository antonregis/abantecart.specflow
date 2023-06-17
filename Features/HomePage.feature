Feature: HomePage


@SmokeTest
Scenario: TC03 Check all Homepage block elements are displayed
	Given I am on the home page
	Then headerstrip block element is displayed
	And headerdetails block element is displayed
	And categorymenu block element is displayed
	And slider block element is displayed
	And promo_section block element is displayed
	And featured block element is displayed
	And latest block element is displayed
	And bestseller block element is displayed
	And special block element is displayed
	And banner block element is displayed
	And popularbrands block element is displayed
	And footersocial block element is displayed
	And footerlinks block element is displayed
	And copyrightbottom block element is displayed

@SmokeTest
Scenario: TC04 Check website logo is displayed correctly
	Given I am on the home page
	Then Logo element is displayed
	And Logo image file exists in the specified Url
