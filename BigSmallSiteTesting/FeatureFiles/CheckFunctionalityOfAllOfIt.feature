Feature: CheckFunctionalityOfAllOfIt
	check All Of It function

@mytag
Scenario: check Functionality of All Of It
	Given user is on home page
	When user click on all of it
	And select sort by option from dropdown
	And Click on item
	And click on add to cart 
	And click on continue shopping
	Then item should be successfully added in cart.
	