IF OBJECT_ID('Product', 'U') IS NOT NULL
    DROP TABLE Product;
IF OBJECT_ID('Customer', 'U') IS NOT NULL
    DROP TABLE Customer;
IF OBJECT_ID('Cart', 'U') IS NOT NULL
    DROP TABLE Cart;
IF OBJECT_ID('Addresses', 'U') IS NOT NULL
    DROP TABLE Addresses;

CREATE TABLE Addresses (
    addressId INT PRIMARY KEY IDENTITY,
    customerId INT NOT NULL,
    street VARCHAR(100) NOT NULL,
    state VARCHAR(100) NOT NULL,
    zipCode INT NOT NULL,
    country VARCHAR(100) NOT NULL,
    roomNumber VARCHAR(100)
);

CREATE TABLE Cart (
    cartId INT PRIMARY KEY IDENTITY
);

CREATE TABLE Customer (
    customerId INT PRIMARY KEY IDENTITY,
    firstName VARCHAR(50),
    lastName VARCHAR(50),
    username VARCHAR(50),
    password VARCHAR(50),
    addressId INT NOT NULL,
    cardNumber VARCHAR(100),
    cardExp VARCHAR(100),
    cardCVC INT,
    cartId INT,
    FOREIGN KEY (addressId) REFERENCES Addresses(addressId),
    FOREIGN KEY (cartId) REFERENCES Cart(cartId)
);

CREATE TABLE Product (
    SKU INT PRIMARY KEY IDENTITY,
    itemName VARCHAR(200) NOT NULL,
    size VARCHAR(50),
    weight FLOAT,
    rating FLOAT,
    manufacturer VARCHAR(50),
    categoryCode INT
);

INSERT INTO Addresses (customerId, street, state, zipCode, country, roomNumber) VALUES 
(6081, '234 busshel st', 'NE', 41131, 'USA', 'addressId'),
(7600, '235 s 11th st', 'MA', 34030, 'USA', 'addressId'),
(4392, '3829 N 58th st', 'OR', 66900, 'USA', 'addressId'),
(2105, '2 doctor drive', 'FL', 71911, 'USA', 'addressId'),
(4821, '2332 hansel dr', 'WA', 22322, 'USA', 'addressId'),
(7382, '1004 dodge st', 'CA', 82473, 'USA', 'addressId'),
(2142, '220 basic dr', 'TX', 33626, 'USA', 'addressId'),
(1358, '9204 peach st', 'IL', 13702, 'USA', 'addressId'),
(3318, '1010 apple blvd', 'CO', 51330, 'USA', 'addressId'),
(7086, '233 180th st', 'CT', 82934, 'USA', 'addressId'),
(9584, '505 marcell ave ', 'VA', 50210, 'USA', 'addressId');

INSERT INTO Cart (cartId) VALUES (20);

INSERT INTO Customer (firstName, lastName, username, password, addressId, cardNumber, cardExp, cardCVC, cartId) VALUES 
('Jamal', 'McAdams', 'JamalMCA', 'Password1', 1, '905550485559099', '04/28', 272, 20),
('Kamel', 'Noah', 'Camel', 'Password2', 2, '814795832036662', '05/24', 382, 21),
('Taylor', 'Fend', 'TaylorFend', 'Password3', 3, '9519683187072534', '07/24', 933, 22),
('Jordan', 'Adams', 'JAdams', 'Password4', 4, '4971401664709365', '03/26', 283, 23),
('George', 'Cooper', 'football101', 'Password5', 5, '7508471520240618', '12/24', 273, 24),
('Anne', 'Foster', 'LittleAnne', 'Password6', 6, '2461241587561712', '11/26', 76, 25),
('Patrick', 'Meyer', 'hattrickpatrick', 'Password7', 7, '6706252404691770', '06/25', 389, 26),
('Alex', 'Garam', 'amcuh', 'Password8', 8, '9489641696291648', '06/26', 37, 27),
('Paul', 'Duke', 'paulplayball', 'Password9', 9, '5704866752906657', '08/28', 273, 28),
('Greyson', 'Smith', 'grAyson', 'Password10', 10, '6232885781601979', '05/28', 304, 29),
('Ruth', 'DeAndre', 'ruthie2003', 'Password11', 11, '3277892792125040', '02/27', 394, 30);

INSERT INTO Product (itemName, size, weight, rating, manufacturer, categoryCode) VALUES 
('Black Short Sleeve Shirt', 'S-XL', 5, 5.0, 'Count Drac', 404),
('Pink Long Sleeve shirt', 'S-XL', 5, 4.8, 'Count Drac', 404),
('Trench Coat', 'S-XL', 12, 3.4, 'Count Drac', 404),
('Hoodie', 'S-XL', 7, 4.5, 'LazyDog', 404),
('Zipper Jacket', 'S-XL', 7, 4.7, 'Puss and Boots', 404),
('Rain Coat', 'S-XL', 8, 4.7, 'Count Drac', 404),
('White Tee', 'S-XL', 5, 5.0, 'Shirts', 404),
('Black Tee', 'S-XL', 5, 5.0, 'Shirts', 404),
('Blue Tee', 'S-XL', 5, 5.0, 'Shirts', 404),
('Red Tee', 'S-XL', 5, 5.0, 'Shirts', 404),
('Black Boots', 'S-XL', 14, 4.7, 'Puss and Boots', 606),
('Brown Boots', 'S-XL', 14, 4.7, 'Puss and Boots', 606),
('White Sneakers', 'S-XL', 10, 4.7, 'Puss and Boots', 606),
('Black Jeans', 'S-XL', 6, 4.8, 'Man in the Yellow Hat', 505),
('Dark Blue Jeans', 'S-XL', 6, 4.6, 'Man in the Yellow Hat', 505),
('Light Blue Jeans', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505),
('Formal Pant - Black', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505),
('Formal Pant - Blue', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505),
('Formal Pant - Grey', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505),
('Grey Sweatpants', 'S-XL', 5, 5.0, 'LazyDog', 505),
('Black - Sweatpants', 'S-XL', 5, 5.0, 'LazyDog', 505),
('Tan - Sweatpants', 'S-XL', 5, 5.0, 'LazyDog', 505);
