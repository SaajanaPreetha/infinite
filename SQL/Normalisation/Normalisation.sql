use InfiniteDB

create table client
(
clientNo int primary key,
cName varchar(30)
)
insert into client values(1,'Sweta'),(2,'Swathi'),(3,'Preetheeba');

select * from client

create table propertydetails
(
PropertyNumber int primary key,
Paddress varchar(30),
rent int
)

insert into propertydetails values(101, '11th street', 1200),(102, '12th street', 1500),(103, '13th street',1800);

select * from propertydetails

create table Owner
(
OwnerNumber int primary key,
OwnerName varchar(30)
)
 
 insert into Owner values(1,'Arun'),(2,'Kavin'),(3,'Kreesty');

 select * from owner

create table property
(
clientNo int,PropertyNumber int,rent_start date,
rent_end date,owner_number int,primary key(clientNo,PropertyNumber),FOREIGN KEY(clientNo)
references client(clientNo),FOREIGN KEY(owner_number)
references Owner(OwnerNumber),foreign key(PropertyNumber) references propertydetails(PropertyNumber)
)


 insert into property values
 (1, 101, 2024-01-01, 2024-12-31, 1),
  (2, 102, 2023-08-15, 2024-08-14, 2),
  (3, 103, 2024-03-01, 2025-02-28, 3);

 select * from property


