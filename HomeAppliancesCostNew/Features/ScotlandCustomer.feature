Feature: ScotlandCustomer

A short summary of the feature

Scenario Outline: As a resident from Scotland estimate of how much electrical appliances cost to run
	Given I am a resident from Scotland
	When I add the list appliances "<apliancename>" average use <hours>, <minutes>, "<frequency>", <rate>, and its average usage and the national average rates
	Then I should get the results table with daily, weekly, monthly, and yearly costs

	Examples: 

	| apliancename     | hours | minutes | frequency | rate |
	| Electric blanket | 3     | 30      | day       | 30   |
	| Immersion heater | 8     | 20      | day       | 30   |
	| Fan heater       | 45    | 30      | week      | 30   |
	| Broadband router | 60    | 20      | week      | 30   |