Feature: BigSmallProject
	Simple calculator for adding two numbers

@mytag
Scenario:To check New User Create Acoount Succesfully or Not 
	Given user is on the HomePage
	When User On Login page
	And User Enter Email Id
	And User Enter Password
	And User Click on SignIn Button
	And Go to Homepage
	Then User shoud able to Create Account Succesfully

Scenario: Check to Delivery is Your Pincode Or Not 
	Given User Clicks on Gift card
	When User Clicks on price
    And User Enters PinCode
	And User Clicks on Check Button
	Then User shoud able to Your Pincode Or Not Succesfully


Scenario: Add item to Wishlist
	Given user is on the HomePage 
    When click on unique rakhi
    And click on item 
	And click add to wishlist button
	Then item should be successfullly added in wishlist.

Scenario:TO fill Coporate deatils
	Given user is on the HomePage 
    When  User click on Coproate 
	And   User Enter Name
	And   User Enter Email
    And   User Enter Phone
	And   User Fill Enquiry
	Then  Click on submit
	

Scenario: Add item to Add To Cart
	Given user is on the HomePage 
    When click on NewProduct
    And click on any one item 
	And click add to cart button
	Then item should be successfullly added in Cart
