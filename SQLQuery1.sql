

Create table Category 
( 
catID int primary key identity, 
catName varchar(150) not null 
)

Create table Customer 
( 
cusID int primary key identity, 
cusName varchar(50) not null,
cusPhone varchar(50), 
cusEmail varchar(50)
)

Create table Supplier 
( 
supID int primary key identity, 
supName varchar(50) not null,
supPhone varchar(50), 
supEmail varchar(50)
)
