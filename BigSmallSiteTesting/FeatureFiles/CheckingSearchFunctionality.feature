Feature: CheckingSearchFunctionality
	

@mytag
Scenario: Checking Search Functionality is working or not
	Given The homepage of BigSmall Shopping site Page
	When User Click on Search bar
	And User enters "<SearchData>" data
	Then System should display relevant search data

	Examples: 
	| SearchData   |
	| harry potter |
	| key chain    |
	| bobble head  |
