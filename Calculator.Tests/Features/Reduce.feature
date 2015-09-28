Feature: Reduce
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of reduce of two numbers

Background: 
	Given Calculator is started
	 
Scenario: Reduce two numbers
	Given I have entered 70 and 50 into the calculator
	And I have selected the reduce operation in the calculator 
	When I calculate
	Then I should see following result: 20
	
Scenario: Negative result
	Given I have entered 70 and 100 into the calculator
	And I have selected the reduce operation in the calculator 
	When I calculate
	Then I should see following result: -30


