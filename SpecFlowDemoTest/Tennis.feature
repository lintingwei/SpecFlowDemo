Feature: Tennis
	Tennis Score Display

@Tennis
Scenario: PlayerA 0 And PlayerB 0
	Given playerA score 0
	And playerB score 0
	When get tennis score display string
	Then the result should be Love All