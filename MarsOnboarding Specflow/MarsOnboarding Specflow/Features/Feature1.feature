Feature: SellerProfileDetails

As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details

Background: Login to the website
	Given User logs in to the website

	Scenario: Add new Language

	When User adds a '<language>' and '<languageLevel>'
	Then the '<language>' and '<languageLevel>' is added successfully on the profile

	Examples: 
	| language | languageLevel    |
	| English  | Native/Bilingual |
	| French   | Conversational   |
		

	Scenario: Update Language
	When User updates a '<language>' and '<languageLevel>'
	Then The '<language>' and '<languageLevel>' is updated successfully on the profile

	Examples: 
	| language | languageLevel    |
	| German   | Basic            |

Scenario: Delete Language
	When User deletes a language
	Then The language is deleted successfully from the user profile


@ignore
Scenario: Verify validation error for Language tab
	When Language Field is left blank
	Then Error message should be displayed 

@ignore
Scenario: Add new Description
	
	When User adds a Description
	Then the description is added successfully

	@ignore
	Scenario: Update new Description
	When User updates new description
	Then the description is updated successfully

@ignore
Scenario: Validation of Description
	When User leaves a blank description
	Then Description is deleted successfully

@ignore
Scenario: Verify validation error for Description tab
	When Description Field is left blank
	Then Error message should be displayed 

@ignore
Scenario: Add new Skill
	
	When User adds a '<skill>' and '<Level>'
	Then the '<skill>' and '<Level>' is added successfully on the profile

	Examples: 
    | skill		| Level		   |
    | Selenium	| Expert       |
    | C#		| Intermediate |

@ignore
Scenario: Update new Skill
	When User updates a skill
	Then Skill is updated successfully

@ignore
Scenario: Delete a new Skill
	When User deletes a skill
	Then Skill is deleted successfully

@ignore
Scenario: Verify validation error for Skill tab
	When Skill Field is left blank
	Then Error message should be displayed  

##	cancel update
##	cancel add

@ignore
	Scenario: Add new Education
	
	When User adds a Education
	Then Education is added successfully

@ignore
Scenario: Update Education
	
	When User updates the Education
	Then Education is updated successfully

@ignore
Scenario: Delete Education
	
	When User deletes Education
	Then Education is deleted successfully

@ignore
Scenario: Add new Certifications
	
	When User adds a '<Certificate>' and '<From>' and '<Year>'
	Then the '<Certificate>' and '<From>' and '<Year>' is added successfully on the profile

	 Examples: 
    | Certificate						| From					 | Year    |
    | Automation Test using Selenium    | INDUSTRYCONNECT        | 2023    |
    

@ignore
Scenario: Update new Certifications
	
When User updates a new certification
Then the certification is updated successfully

@ignore
Scenario: Delete new Certifications
	
	When User deletes a new certification
	Then the certification is deleted successfully
	
	## left pane
	
@ignore
Scenario: Change user Availability
	
	When User edits to change the availability
	Then the user availability is updated successfully on the user profile
	
	@ignore
	Scenario: Cancel Change user Availability
	
	When User edits to change the availability and then cancels
	Then the user availability is updated successfully on the user profile
	
	@ignore
	Scenario: Change user Hours
	
	When User changes the Hours
	Then the user hours is updated successfully on the user profile

	@ignore
	Scenario: Change user Earn Target
	
	When User changes the earn target
	Then the user availability is updated successfully on the user profile

	## edit name