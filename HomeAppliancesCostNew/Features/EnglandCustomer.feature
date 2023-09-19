Feature: EnglandCustomer

A short summary of the feature

Scenario Outline: As a resident from England estimate of how much electrical appliances cost to run
	Given I am a resident from England
	When I add the list appliances "<apliancename>" average use <hours>, <minutes>, "<frequency>", <rate>, and its average usage and the national average rate
	Then I should get the results table with daily, weekly, monthly, and yearly cost

	Examples: 

	| apliancename           | hours | minutes | frequency | rate |
	| Electric blanket       | 1     | 30      | day       | 34   |
	| Immersion heater       | 40    | 30      | week      | 34   |
	| Broadband router       | 50    | 20      | week      | 34   |
	| Games console          | 1     | 10      | day       | 34   |
	| PC or desktop computer | 40    | 30      | Week      | 34   |
	| Dishwasher             | 2     | 20      | day       | 34   |
	| Kettle                 | 1     | 44      | day       | 34   |