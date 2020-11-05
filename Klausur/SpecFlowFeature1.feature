Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: calculate the sine
	Given the radian is Pi
	When the sine is clicked
	Then the result should be 0

Scenario: calculate the cosine
    Given the radian is Pi
	When the cosine is clicked
	Then the result should be -1

Scenario: calculate the tangens
    Given the radian is Pi
	When the tangens is clicked
	Then the result should be 0