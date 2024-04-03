use gkodali;

drop table if exists Product;
drop table if exists Manufacturer;
drop table if exists Customer;
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

create table Customer(
  customerId int not null primary key auto_increment,
  firstName varchar(50),
  lastName varchar(50),
  username varchar(50),
  password varchar(50),
  addressId int(100),
  cardNumber int (100),
  cardExp varchar(100),
  cardCVC int(4), 
  foreign key (addressId) references Addresses(addressId)
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

insert into Manufacturer (manufacturerId,comapnyName) values (1, 'Lou');
select * from Manufacturer;

