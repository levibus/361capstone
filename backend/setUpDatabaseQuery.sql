    DROP TABLE Product;
    DROP TABLE Customer;
    DROP TABLE Cart;
    DROP TABLE Addresses;

CREATE TABLE Addresses (
    addressId INT PRIMARY KEY IDENTITY,
    customerId INT NOT NULL,
    street VARCHAR(100) NOT NULL,
	city VARCHAR(100) NOT NULL,
    stateName VARCHAR(100) NOT NULL,
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
    username VARCHAR(50) UNIQUE,
    password VARCHAR(50),
    addressId INT,
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
    cost FLOAT,
    rating FLOAT,
    manufacturer VARCHAR(50),
    categoryId INT,
	img NVARCHAR(500),
	imgId INT
);

GO

INSERT INTO Addresses (customerId, street, city, stateName, zipCode, country, roomNumber) VALUES 
(6081, '234 busshel st', 'city1', 'NE', 41131, 'USA', 'addressId'),
(7600, '235 s 11th st', 'city2', 'MA', 34030, 'USA', 'addressId'),
(4392, '3829 N 58th st', 'city3', 'OR', 66900, 'USA', 'addressId'),
(2105, '2 doctor drive', 'city4', 'FL', 71911, 'USA', 'addressId'),
(4821, '2332 hansel dr', 'city5', 'WA', 22322, 'USA', 'addressId'),
(7382, '1004 dodge st', 'city6', 'CA', 82473, 'USA', 'addressId'),
(2142, '220 basic dr', 'city7', 'TX', 33626, 'USA', 'addressId'),
(1358, '9204 peach st', 'city8', 'IL', 13702, 'USA', 'addressId'),
(3318, '1010 apple blvd', 'city9', 'CO', 51330, 'USA', 'addressId'),
(7086, '233 180th st', 'city10', 'CT', 82934, 'USA', 'addressId'),
(9584, '505 marcell ave ', 'city11', 'VA', 50210, 'USA', 'addressId');

INSERT INTO Customer (firstName, lastName, username, password, addressId, cardNumber, cardExp, cardCVC) VALUES 
('Jamal', 'McAdams', 'JamalMCA', 'Password1', 1, '905550485559099', '04/28', 272),
('Kamel', 'Noah', 'Camel', 'Password2', 2, '814795832036662', '05/24', 382),
('Taylor', 'Fend', 'TaylorFend', 'Password3', 3, '9519683187072534', '07/24', 933),
('Jordan', 'Adams', 'JAdams', 'Password4', 4, '4971401664709365', '03/26', 283),
('George', 'Cooper', 'football101', 'Password5', 5, '7508471520240618', '12/24', 273),
('Anne', 'Foster', 'LittleAnne', 'Password6', 6, '2461241587561712', '11/26', 76),
('Patrick', 'Meyer', 'hattrickpatrick', 'Password7', 7, '6706252404691770', '06/25', 389),
('Alex', 'Garam', 'amcuh', 'Password8', 8, '9489641696291648', '06/26', 37),
('Paul', 'Duke', 'paulplayball', 'Password9', 9, '5704866752906657', '08/28', 273),
('Greyson', 'Smith', 'grAyson', 'Password10', 10, '6232885781601979', '05/28', 304),
('Ruth', 'DeAndre', 'ruthie2003', 'Password11', 11, '3277892792125040', '02/27', 394);

GO

INSERT INTO Product (itemName, size, cost, rating, manufacturer, categoryId, img, imgId) VALUES 
('Black Short Sleeve Shirt', 'S-XL', 5, 5.0, 'Count Drac', 404, 'https://m.media-amazon.com/images/I/51z12hIlNPL.jpg', 1),
('Pink Long Sleeve shirt', 'S-XL', 5, 4.8, 'Count Drac', 404, 'https://image.spreadshirtmedia.com/image-server/v1/compositions/T2093A251PA4357PT17X45Y38D1052711728W20994H20546/views/1,width=550,height=550,appearanceId=251,backgroundColor=BEBEBE,noPt=true/cat-wearing-pink-pajamas-doodle-unisex-long-sleeve-hoodie-shirt.jpg', 2),
('Trench Coat', 'S-XL', 12, 3.4, 'Count Drac', 404, 'https://img.freepik.com/premium-photo/cat-wearing-trench-coat-hat_879398-200.jpg', 3),
('Hoodie', 'S-XL', 7, 4.5, 'LazyDog', 404, 'https://shutupandtakemymoney.com/wp-content/uploads/2018/10/pet-hoodie-cat-hoodie.jpg', 4),
('Zipper Jacket', 'S-XL', 7, 4.7, 'Puss and Boots', 404, 'https://img.freepik.com/premium-photo/cat-wearing-pink-jacket-with-black-zipper-it_905510-24816.jpg', 5),
('Rain Coat', 'S-XL', 8, 4.7, 'Count Drac', 404, 'https://img.freepik.com/premium-photo/close-up-cat-raincoat-generative-ai_771703-2380.jpg', 6),
('White Tee', 'S-XL', 5, 5.0, 'Shirts', 404, 'https://thumbs.dreamstime.com/b/cat-white-t-shirt-mockup-generative-ai-cat-white-t-shirt-mockup-generative-ai-ai-generated-289523637.jpg', 7),
('Black Tee', 'S-XL', 5, 5.0, 'Shirts', 404, 'https://picfiles.alphacoders.com/478/478908.jpg', 8),
('Blue Tee', 'S-XL', 5, 5.0, 'Shirts', 404, 'https://img.freepik.com/premium-photo/cat-wearing-blue-shirt-with-yellow-flowers-it_933706-528.jpg', 9),
('Red Tee', 'S-XL', 5, 5.0, 'Shirts', 404, 'https://www.shutterstock.com/image-photo/cool-cat-portrait-fawn-lilac-600nw-2066923760.jpg', 10),
('Black Boots', 'S-XL', 14, 4.7, 'Puss and Boots', 606, 'https://people.com/thmb/hcUEt5vxi308-d7Yb8y0LoOvzQU=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(149x0:151x2)/puss-boots-300-6b114bd07a644789a4d6102ea32ba3ab.jpg', 11),
('Brown Boots', 'S-XL', 14, 4.7, 'Puss and Boots', 606, 'https://thumbs.dreamstime.com/b/cat-winter-coat-boots-cat-wearing-hat-winter-coat-boots-white-background-121726418.jpg', 12),
('White Sneakers', 'S-XL', 10, 4.7, 'Puss and Boots', 606, 'https://selmainthecity.com/wp-content/uploads/2012/03/p1130198.jpg', 13),
('Black Jeans', 'S-XL', 6, 4.8, 'Man in the Yellow Hat', 505, 'https://media.cnn.com/api/v1/images/stellar/prod/131107165138-13-meowtfit.jpg', 14),
('Dark Blue Jeans', 'S-XL', 6, 4.6, 'Man in the Yellow Hat', 505, 'https://img.freepik.com/premium-photo/cat-wearing-tshirt-jeans-red-cads_1002188-61.jpg', 15),
('Light Blue Jeans', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505, 'https://i0.wp.com/theverybesttop10.com/wp-content/uploads/2015/06/Top-10-Fashionable-Cats-Wearing-Denim-10.jpg', 16),
('Formal Pant - Black', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505, 'https://img.pixers.pics/pho_wat(s3:700/FO/50/96/45/33/700_FO50964533_a21b13e3a545033f4d51801e5f8128ed.jpg,700,700,cms:2018/10/5bd1b6b8d04b8_220x50-watermark.png,over,480,650,jpg)/posters-funny-fluffy-cat-in-a-business-suit.jpg.jpg', 17),
('Formal Pant - Blue', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505, 'https://cdn1.vectorstock.com/i/1000x1000/02/50/cat-in-a-suit-vector-27520250.jpg', 18),
('Formal Pant - Grey', 'S-XL', 6, 4.9, 'Man in the Yellow Hat', 505, 'https://tile.loc.gov/storage-services/service/pnp/ppmsca/19000/19072v.jpg', 19),
('Sweatpant - Grey', 'S-XL', 5, 5.0, 'LazyDog', 505, 'https://image.tensorartassets.com/cdn-cgi/image/anim=false,w=2560,f=jpeg,q=85/posts/images/705314126552933762/484febfe-9479-4de5-847f-d7e37d99f2df.jpg', 20), 
('Sweatpants - Black', 'S-XL', 5, 5.0, 'LazyDog', 505, 'https://www.wfla.com/wp-content/uploads/sites/71/2021/10/Black-Cat-2.jpg', 21),
('Sweatpants - Purple', 'S-XL', 5, 5.0, 'LazyDog', 505, 'https://i.pinimg.com/736x/7c/83/ad/7c83ad364b46b3f49628d6a60d3a8fb8.jpg', 22); -- pinterest
