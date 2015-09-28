Feature: Add
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given Calculator is started

Scenario: Add two numbers 
	Given I have entered 70 and 50 into the calculator
	And I have selected the add operation in the calculator
	When I calculate
	Then I should see following result: 120


