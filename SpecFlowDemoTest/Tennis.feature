Feature: Tennis
	Tennis Score Display

@Tennis
Scenario: PlayerA 0 And PlayerB 0
	Given playerA score 0
	And playerB score 0
	When get tennis score display string
	Then the score display should be Love All

@Tennis
Scenario: PlayerA 1 And PlayerB 0
	Given playerA score 1
	And playerB score 0
	When get tennis score display string
	Then the score display should be Fifteen Love

@Tennis
Scenario: PlayerA 2 And PlayerB 0
	Given playerA score 2
	And playerB score 0
	When get tennis score display string
	Then the score display should be Thirty Love

@Tennis
Scenario: PlayerA 3 And PlayerB 0
	Given playerA score 3
	And playerB score 0
	When get tennis score display string
	Then the score display should be Forty Love