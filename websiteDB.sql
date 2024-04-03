use gkodali;

drop table if exists Product;
drop table if exists Manufacturer;
drop table if exists Customer;
drop table if exists Cart;
drop table if exists Addresses;

create table Addresses(
  addressId int not null primary key auto_increment,
  customerId int not null,
  street varchar(100) not null,
  state varchar(100) not null,
  zipCode int(100) not null,
  country varchar(100) not null,
  roomNumber varchar(100)
  #prevent duplicate entries
  #constraint uniquePair unique index(musicianId,bandId)
)engine=InnoDB,collate=latin1_general_cs;

create table Cart(
  cartId int not null primary key auto_increment
)engine=InnoDB,collate=latin1_general_cs;

create table Customer(
  customerId int not null primary key auto_increment,
  firstName varchar(50),
  lastName varchar(50),
  username varchar(50),
  password varchar(50),
  addressId int(100),
  cardNumber int (100),
  cardExp varchar(100),
  cardCVC int(3), 
  cartId int(100),
  foreign key (addressId) references Addresses(addressId),
  foreign key (cartId) references Cart(cartId)
)engine=InnoDB,collate=latin1_general_cs;

create table Manufacturer (
  manufacturerId int not null primary key auto_increment,
  comapnyName varchar(50)
)engine=InnoDB,collate=latin1_general_cs;

create table Product (
  SKU int not null primary key auto_increment,
  itemName varchar(200) not null,
  size int(50),
  weight float(50),
  rating float(50),
  manufacturerId int(50),
  madeOf varchar(50),
  categoryCode int(50),
  foreign key (manufacturerId) references Manufacturer(manufacturerId)
)engine=InnoDB,collate=latin1_general_cs;


 insert into Addresses 
 (addressId, customerId, street, 			state,	zipCode, 	country, roomNumber) values 
 ("72133", 	"6081", 	"234 busshel st", 	"NE", 	"41131", 	"USA", 	"addressId"),
 ("72686", 	"7600", 	"235 s 11th st", 	"MA", 	"34030", 	"USA", 	"addressId"), 
 ("49368", 	"4392", 	"3829 N 58th st", 	"OR", 	"66900", 	"USA", 	"addressId"), 
 ("29946", 	"2105", 	"2 doctor drive", 	"FL", 	"71911", 	"USA", 	"addressId"), 
 ("66516", 	"4821", 	"2332 hansel dr", 	"WA", 	"22322", 	"USA", 	"addressId"), 
 ("58733", 	"7382", 	"1004 dodge st", 	"CA", 	"82473", 	"USA", 	"addressId"), 
 ("67197", 	"2142", 	"220 basic dr", 	"TX", 	"33626", 	"USA", 	"addressId"), 
 ("47104", 	"1358", 	"9204 peach st", 	"IL", 	"13702", 	"USA", 	"addressId"), 
 ("31940", 	"3318", 	"1010 apple blvd", 	"CO", 	"51330", 	"USA", 	"addressId"), 
 ("78596", 	"7086", 	"233 180th st", 	"CT", 	"82934", 	"USA", 	"addressId"), 
 ("35119", 	"9584", 	"505 marcell ave ", "VA", 	"50210", 	"USA", 	"addressId");
 
insert into Customer 
 (customerId, 	firstName, 	lastName, 	username,		password, 		addressId, 	cardNumber, 	  cardExp,  cardCVC, 	cartId) values 
 ("1", 			"Jamal", 	"McAdams", 	"JamalMCA", 	"Password1", 	"72133",	"905550485559099", "04/28", "272", 		"20"),
 ("2", 			"Kamel", 	"Noah", 	"Camel", 		"Password2", 	"72686", 	"814795832036662","05/24", 	"382", 		"21"), 
 ("3", 			"Taylor", 	"Fend", 	"TaylorFend", 	"Password3", 	"49368", 	"9519683187072534","07/24", "933", 		"22"), 
 ("4", 			"Jordan", 	"Adams", 	"JAdams", 		"Password4", 	"29946", 	"4971401664709365","03/26", "283", 		"23"), 
 ("5", 			"George", 	"Cooper", 	"football101",	"Password5", 	"66516", 	"7508471520240618","12/24", "273", 		"24"), 
 ("6", 			"Anne", 	"Foster", 	"LittleAnne", 	"Password6", 	"58733", 	"2461241587561712","11/26", "076", 		"25"), 
 ("7", 			"Patrick", 	"Meyer", 	"hattrickpatrick","Password7", 	"67197", 	"6706252404691770","06/25", "389", 		"26"), 
 ("8", 			"Alex", 	"Garam", 	"amcuh", 		"Password8", 	"67197", 	"9489641696291648","06/26", "037", 		"27"), 
 ("9", 			"Paul", 	"Duke", 	"paulplayball", "Password9", 	"47104", 	"5704866752906657","08/28", "273", 		"28"), 
 ("10", 		"Greyson", 	"Smith", 	"grAyson", 		"Password10", 	"31940", 	"6232885781601979","05/28", "304", 		"29"), 
 ("11", 		"Ruth", 	"DeAndre", "ruthie2003", 	"Password11", 	"78596", 	"3277892792125040","02/27", "394", 		"30");
 
  insert into Manufacturer 
 (manufacturerId, 	comapnyName) values 
 ("1001", 		  	"Puss and Boots"),
 ("2002", 		  	"Shirts"),
 ("3003", 		  	"LazyDog"),
 ("4004", 		  	"Hoodies For All"),
 ("5005", 		  	"Count Drac"),
 ("6006", 		  	"Man in the Yellow Hat");
 
 insert into Product 
 (SKU, 			itemName, 						size, 		weight,			rating, 	manufacturerId, 	categoryCode) values 
 ("72564", 		"Black Short Sleeve Shirt", 	"S-XL", 	"5", 			"5.0", 		"5005",				"404"),
 ("59867", 		"Pink Long Sleeve shirt", 		"S-XL", 	"5", 			"4.8", 		"5005", 			"404"), 
 ("55578", 		"Trench Coat", 					"S-XL", 	"12", 			"3.4", 		"5005",				"404"),
 ("93303", 		"Hoodie", 						"S-XL", 	"7", 			"4.5", 		"3003", 			"404"), 
 ("14626", 		"Zipper Jacket", 				"S-XL", 	"7", 			"4.7", 		"6006",				"404"),
 ("89559",		"Rain Coat", 					"S-XL", 	"8", 			"4.7", 		"5005", 			"404"), 
 ("83873",		"White Tee", 					"S-XL", 	"5", 			"5.0", 		"2002",				"404"),
 ("56552", 		"Black Tee", 					"S-XL", 	"5", 			"5.0", 		"2002", 			"404"), 
 ("68054", 		"Blue Tee", 					"S-XL", 	"5", 			"5.0", 		"2002",				"404"),
 ("93542", 		"Red Tee", 						"S-XL", 	"5", 			"5.0", 		"2002", 			"404"), 
 ("52209", 		"Black Boots", 					"S-XL", 	"14", 			"4.7", 		"1001",				"606"),
 ("33792", 		"Brown Boots", 					"S-XL", 	"14", 			"4.7", 		"1001", 			"606"), 
 ("27433", 		"White Sneakers", 				"S-XL", 	"10", 			"4.7", 		"1001",				"606"),
 ("92787", 		"Black Jeans", 					"S-XL", 	"6", 			"4.8", 		"72686", 			"505"), 
 ("33592", 		"Dark Blue Jeans", 				"S-XL", 	"6", 			"4.6", 		"6006",				"505"),
 ("60542", 		"Light Blue Jeans", 			"S-XL", 	"6", 			"4.9", 		"6006", 			"505"), 
 ("56285", 		"Formal Pant - Black", 			"S-XL", 	"6", 			"4.9", 		"6006",				"505"),
 ("44018", 		"Formal Pant - Blue", 			"S-XL", 	"6", 			"4.9", 		"6006", 			"505"), 
 ("57925", 		"Formal Pant - Grey", 			"S-XL", 	"6", 			"4.9", 		"6006",				"505"),
 ("65552", 		"Grey Sweatpants", 				"S-XL", 	"5", 			"5.0", 		"3003", 			"505"), 
 ("65032",		"Black - Sweatpants", 			"S-XL", 	"5", 			"5.0", 		"3003",				"505"),
 ("11128",		"Tan - Sweatpants", 			"S-XL", 	"5", 			"5.0", 		"3003", 			"505"); 
 
 
select * from Product;
select firstName from Customer;

