USE [ComputerStore]
GO

CREATE TABLE Manufacturers (
	Code INT Primary key,
	[Name] VARCHAR(255)
)

CREATE TABLE Products (
	Code INT Primary key,
	Name VARCHAR(255),
	PRICE DECIMAL NOT NULL,
	Manufacturer INT NOT NULL,
	FOREIGN KEY (Manufacturer) REFERENCES Manufacturers(Code)
) 

INSERT INTO Manufacturers(Code,Name) VALUES(1,'Sony');
INSERT INTO Manufacturers(Code,Name) VALUES(2,'Creative Labs');
INSERT INTO Manufacturers(Code,Name) VALUES(3,'Hewlett-Packard');
INSERT INTO Manufacturers(Code,Name) VALUES(4,'Iomega');
INSERT INTO Manufacturers(Code,Name) VALUES(5,'Fujitsu');
INSERT INTO Manufacturers(Code,Name) VALUES(6,'Winchester');

INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(1,'Hard drive',240,5);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(2,'Memory',120,6);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(3,'ZIP drive',150,4);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(4,'Floppy disk',5,6);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(5,'Monitor',240,1);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(6,'DVD drive',180,2);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(7,'CD drive',90,2);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(8,'Printer',270,3);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(9,'Toner cartridge',66,3);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(10,'DVD burner',180,2);

SELECT Name FROM Products

SELECT NAME, PRICE FROM Products

SELECT * FROM Products WHERE Price BETWEEN 60 AND 120

SELECT NAME, PRICE * 100 AS 'Price In Cents' FROM Products

SELECT AVG(Price) AS 'Avarage Price' FROM Products

SELECT AVG(Price) FROM Products WHERE Manufacturer = 2

SELECT COUNT(*) From Products Where Price >= 180

SELECT Name, Price From Products
Where PRICE >= 180
ORDER BY Price Desc, NAME 

SELECT * FROM Products AS p
	JOIN Manufacturers AS m
	ON ( p.Manufacturer = m.Code)

 SELECT * FROM Products, Manufacturers
   WHERE Products.Manufacturer = Manufacturers.Code;

SELECT p.Name, p.Price, m.Name FROM Products AS p
	JOIN Manufacturers AS m
	ON( p.Manufacturer = m.Code)

  SELECT AVG(Price), Manufacturer
    FROM Products
GROUP BY Manufacturer;

SELECT AVG(p.Price), m.Name FROM Products as p
JOIN Manufacturers as m
	on p.Manufacturer = m.Code
GROUP bY m.Name

 SELECT AVG(Price), Manufacturers.Name
   FROM Products, Manufacturers
   WHERE Products.Manufacturer = Manufacturers.Code
   GROUP BY Manufacturers.Name;

SELECT m.Name From Manufacturers AS m
Join Products AS p
	On m.Code = p.Manufacturer
GROUP BY m.Name
Having AVG(p.Price) >= 150

SELECT Name, Price FROM Products
WHERE Price = (SELECT MIN(Price) FROM Products)

SELECT m.Name, p.Name, p.Price FROM Products as p
JOIN Manufacturers as m
ON p.Manufacturer = m.Code
	AND PRICE = 
		(
			SELECT MAX(PRICE) FROM PRODUCTS as a
			WHERE a.Manufacturer = m.Code
		)

INSERT INTO Products 
( 
	Code,
	Name,
	Price,
	Manufacturer
)
	VALUES
(
11,
	'Loudspeakers',
	 70, 
	 2
)

UPDATE Products
	SET Name = 'Laser Printer'
	WHERE Code = 8;

UPDATE Products
	SET PRICE = Price - ( PRICE * 0.1);

UPDATE Products
	SET PRICE = Price - ( PRICE * 0.1)
	WHERE Price >= 120
