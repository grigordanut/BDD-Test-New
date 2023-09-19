Feature: ScotlandCustomer

A short summary of the feature

Scenario Outline: As a resident from Scotland estimate of how much electrical appliances cost to run
	Given I am a resident from Scotland
	When I add the list appliances "<apliancename>" average use <hours>, <minutes>, "<frequency>", <rate>, and its average usage and the national average rates
	Then I should get the results table with daily, weekly, monthly, and yearly costs

	Examples: 

	| apliancename           | hours | minutes | frequency | rate |
	| Electric blanket       | 1     | 45      | day       | 67   |
	| Fan heater             | 2     | 30      | day       | 67   |
	| Broadband router       | 45    | 20      | week      | 67   |
	| Games console          | 2     | 15      | day       | 67   |
	| PC or desktop computer | 40    | 30      | week      | 67   |