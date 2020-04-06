Feature: Adding, Deleting and sorting items to the wishlist
	In order to be able to decide to shortlist best cars for myself 
	As a customer
	I need to add, delete and sort items to my checklist

@Sanity
Scenario: Add and remove a product to and from the wishlist respectively
	Given I am on the cargiant Home page
	When I login with my user name and password 
	And I search for products
    	And I choose to add a product
    	Then the product should be there in my wishlist
	And I choose to delete the product
	Then the product should disappear from my wishlist
