Feature: GiftSite
To check the giftcard is working	

@mytag
Scenario: To Add the Gift card  
	Given User Clicks on Gift card
	When User Clicks on price
	And USer Clicks on Wishlist
    And User Enters PinCode
	And User Clicks on Check Button
	And User Clicks on Add to cart
	Then User Click on Continue Shopping 
	