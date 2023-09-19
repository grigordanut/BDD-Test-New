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
	| Dehumidifier           | 30    | 25      | week      | 67   |
	| Dishwasher             | 2     | 25      | day       | 67   |
	| Oven                   | 1     | 30      | day       | 67   |
	| Iron                   | 2     | 40      | day       | 67   |
	| Vacuum cleaner         | 1     | 10      | day       | 67   |