Feature: ContactUs


@SmokeTest
Scenario Outline: TC07A. Check user can submit an enquiry using valid entries
	Given I am on the home page
	When I click Contact Us on the footer block
	And I enter '<firstName>' in the First name field
	And I enter '<email>' in the Email field
	And I enter '<enquiryMsg>' in the Enquiry Text area
	And I Click Submit
	Then I get a success message "Your enquiry has been successfully sent to the store owner!"

	Examples: 
	| firstName | email           | enquiryMsg                 |
	| anthony   | dummy@email.com | Dummy lorem ipsum message. |
