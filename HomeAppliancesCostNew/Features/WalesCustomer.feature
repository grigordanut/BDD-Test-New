Feature: WalesCustomer

A short summary of the feature

Scenario Outline: As a resident from Wales I need to know estimate of how much electrical appliances cost to run
	Given I am a resident from Wales
	When I add the list appliance "<apliancename>" average use <hours>, <minutes>, "<frequency>", <rate>, and its average usage and the national average rates
	Then I should get the results table with daily, weekly, monthly, and yearly costs is

	Examples: 

	| apliancename     | hours | minutes | frequency | rate |
	| Immersion heater | 35    | 30      | week      | 67   |
	| Broadband router | 50    | 30      | week      | 67   |
	| Washing machine  | 3     | 20      | day       | 67   |
	| Microwave        | 1     | 15      | day       | 67   |
	| Slow cooker      | 2     | 40      | day       | 67   |
