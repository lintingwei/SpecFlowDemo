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

@Tennis
Scenario: PlayerA 0 And PlayerB 1
	Given playerA score 0
	And playerB score 1
	When get tennis score display string
	Then the score display should be Love Fifteen

@Tennis
Scenario: PlayerA 0 And PlayerB 2
	Given playerA score 0
	And playerB score 2
	When get tennis score display string
	Then the score display should be Love Thirty

@Tennis
Scenario: PlayerA 0 And PlayerB 3
	Given playerA score 0
	And playerB score 3
	When get tennis score display string
	Then the score display should be Love Forty

@Tennis
Scenario: PlayerA 1 And PlayerB 1
	Given playerA score 1
	And playerB score 1
	When get tennis score display string
	Then the score display should be Fifteen All

@Tennis
Scenario: PlayerA 2 And PlayerB 2
	Given playerA score 2
	And playerB score 2
	When get tennis score display string
	Then the score display should be Thirty All

@Tennis
Scenario: PlayerA 3 And PlayerB 3
	Given playerA score 3
	And playerB score 3
	When get tennis score display string
	Then the score display should be Deuce

@Tennis
Scenario: PlayerA 4 And PlayerB 4
	Given playerA score 4
	And playerB score 4
	When get tennis score display string
	Then the score display should be Deuce

@Tennis
Scenario: PlayerA 4 And PlayerB 3
	Given playerA score 4
	And playerB score 3
	When get tennis score display string
	Then the score display should be Player A Adv

@Tennis
Scenario: PlayerA 5 And PlayerB 3
	Given playerA score 5
	And playerB score 3
	When get tennis score display string
	Then the score display should be Player A Won