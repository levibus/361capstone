The following files are provided in the C# middleware:

## Customer.cs
Defines the customer class

## Cart.cs
Defines the cart class

## Product.cs
Defines the product class

## Addresses.cs
Defines the addresses class *not implemented

## CustomerController.cs
Get(string username, string password)
- returns customer given username and password
Post(Customer cust)
- adds a customer to the database given a Customer-type variable that contains the firstName, lastName, username, and password
Put(int customerId, string firstName)
- *not implemented
Delete(int customerId)
- *not implemented

## CustomerTestController
Get()
- returns every customer

## CartController.cs
Get(Cart cart)
- returns the cart associated with a customerId
Post(Cart cart)
- adds items to the cart
    - if the item is new: creates new item
    - if the item is a duplicate: increases the quantity
Delete(Cart cart)
- deletes an item from the cart 

## CartTestController.cs
Get()
- returns every item in every cart

## ProductController.cs
Get()
- returns every product

## CategoryController.cs
Get(int categoryId)
- returns products from a certain category

## SKUController.cs *not implemented*
Get(Cart cart)
- returns a product given an SKU


