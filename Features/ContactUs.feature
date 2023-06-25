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


@SmokeTest
Scenario: TC07B. Check user cannot submit a blank enquiry
	Given I am on the home page
	When I click Contact Us on the footer block
	And Leave all Contact Us feilds blank
	And I Click Submit
	Then First name field returns with error message "First name: is required field! Name must be between 3 and 32 characters!"
	And Email field returns with error message "Email: is required field! E-Mail Address does not appear to be valid!"
	And Enquiry text area returns with error message "Enquiry: is required field! Enquiry must be between 10 and 3000 characters!"