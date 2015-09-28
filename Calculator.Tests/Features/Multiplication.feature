Feature: Multiplication
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the multiplication of two numbers
	
Background: 
	Given Calculator is started 
	
Scenario: Multiplication of two numbers
	Given I have entered 5 and 2 into the calculator
	And I have selected the multiplication operation in the calculator
	When I calculate
	Then I should see following result: 10



