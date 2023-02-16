Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowSessionExample/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers which will result in 120
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	

















	
Scenario: Subtract second number from first number in 0
	Given the first number is 10
	And the second number is 10
	When the second is subtracted from first
	Then the result should be 0

	


















	
Scenario: Subtract two numbers base on example
	Given the first number is <firstNumber>
	And the second number is <secondNumber>
	When the two numbers are added
	Then the result should be <result>

Examples: 
	| firstNumber | secondNumber | result |
	| 30          | 10           | 20     |
	| 10          | 30           | -20    |