Feature: Division
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the division of two numbers
	
Background: 
	Given Calculator is started 
	 
Scenario: Division of two numbers 
	Given I have entered 10 and 2 into the calculator
	And I have selected the division operation in the calculator
	When I calculate
	Then I should see following result: 5
		
Scenario: Division by zero
	Given I have entered 10 and 0 into the calculator
	And I have selected the division operation in the calculator
	Then I should not be able to calculate



