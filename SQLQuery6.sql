﻿DROP TABLE IF EXISTS Category;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Supplier;
DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS tblMain;
DROP TABLE IF EXISTS tblDetails;

CREATE TABLE Category (
    catID INT PRIMARY KEY IDENTITY,
    catName VARCHAR(150) NOT NULL
);

CREATE TABLE Customer (
    cusID INT PRIMARY KEY IDENTITY,
    cusName VARCHAR(50) NOT NULL,
    cusPhone VARCHAR(50),
    cusEmail VARCHAR(50)
);

CREATE TABLE Supplier (
    supID INT PRIMARY KEY IDENTITY,
    supName VARCHAR(50) NOT NULL,
    supPhone VARCHAR(50),
    supEmail VARCHAR(50)
);

CREATE TABLE Product (
    proID INT PRIMARY KEY IDENTITY,
    pName VARCHAR(50),
    pCatID INT,
    pBarcode VARCHAR(50),
    pCost FLOAT,
    pPrice FLOAT,
    pImage IMAGE,
    FOREIGN KEY (pCatID) REFERENCES Category(catID)
);

CREATE TABLE tblMain (
    MainID INT PRIMARY KEY IDENTITY,
    mdate DATE,
    mType VARCHAR(50),
    mSupCusID INT
);

CREATE TABLE tblDetails (
    detailID INT PRIMARY KEY IDENTITY,
    dMainID INT,
    productID INT,
    qty INT,
    price FLOAT,
    amount FLOAT,
    cost FLOAT,
    FOREIGN KEY (dMainID) REFERENCES tblMain(MainID),
    FOREIGN KEY (productID) REFERENCES Product(proID)
);
