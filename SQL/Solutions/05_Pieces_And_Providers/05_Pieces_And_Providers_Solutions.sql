CREATE DATABASE Pieces_And_Providers
GO

USE Pieces_And_Providers
GO

CREATE TABLE Pieces
(
	Code INT PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL
)

CREATE TABLE Providers
(
	Code VARCHAR(4) PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL
)

CREATE TABLE Provides
(
	Piece INT NOT NULL,
	[Provider] VARCHAR(4) NOT NULL,
	Price INT NOT NULL
	CONSTRAINT fk_Pieces_Provides
		FOREIGN KEY (Piece) REFERENCES Pieces(Code),
	CONSTRAINT fk_Providers_Provides
		FOREIGN KEY ([Provider]) REFERENCES Providers(Code),
	PRIMARY KEY (Piece, [Provider])
)

INSERT INTO Providers(Code, [Name]) VALUES('HAL','Clarke Enterprises');
 INSERT INTO Providers(Code, [Name]) VALUES('RBT','Susan Calvin Corp.');
 INSERT INTO Providers(Code, [Name]) VALUES('TNBC','Skellington Supplies');
 
 INSERT INTO Pieces(Code, [Name]) VALUES(1,'Sprocket');
 INSERT INTO Pieces(Code, [Name]) VALUES(2,'Screw');
 INSERT INTO Pieces(Code, [Name]) VALUES(3,'Nut');
 INSERT INTO Pieces(Code, [Name]) VALUES(4,'Bolt');
 
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(1,'HAL',10);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(1,'RBT',15);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(2,'HAL',20);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(2,'RBT',15);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(2,'TNBC',14);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(3,'RBT',50);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(3,'TNBC',45);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(4,'HAL',5);
 INSERT INTO Provides(Piece, [Provider], Price) VALUES(4,'RBT',7);

--1. Select the name of all the pieces. 
SELECT Name FROM Pieces;

--2. Select all the providers' data
SELECT * FROM Providers

--3. Obtain the average price of each piece (show only the piece code and the average price).
SELECT Piece, AVG(Price) FROM Provides GROUP BY Piece

--4. Obtain the names of all providers who supply piece 1.
SELECT Name FROM Providers
WHERE CODE IN
(
	SELECT Provider FROM Provides WHERE Piece = 1 
)

--5. Select the name of pieces provided by provider with code "HAL".
SELECT Name FROM Pieces
WHERE CODE IN
(
	SELECT Piece FROM Provides WHERE Provider = 'HAL'
);

--6. For each piece, find the most expensive offering of that piece and include the piece name, provider name, and price 
--(note that there could be two providers who supply the same piece at the most expensive price).
SELECT Pieces.Name, Providers.Name, Price
FROM Pieces 
			Inner JOIN Provides ON Pieces.Code = Provides.Piece
			Inner JOIN Providers ON Providers.Code = Provides.Provider
		WHERE Price = 
		(
			SELECT MAX(PRICE) FROM Provides WHERE Piece = Pieces.Code
		)

--7. Add an entry to the database to indicate that "Skellington Supplies" (code "TNBC") 
--will provide sprockets (code "1") for 7 cents each.

INSERT INTO Provides
(
	Piece,
	Provider,
	Price
) 
Values
(
	1,
	'TNBC',
	7
);

--8.Increase all prices by one cent.
UPDATE Provides
	SET Price = Price + 1;

--9. Update the database to reflect that "Susan Calvin Corp." (code "RBT") will not supply bolts (code 4).
DELETE FROM Provides 
	WHERE Provider = 'RBT'
	AND Piece = 4;

--10. Update the database to reflect that "Susan Calvin Corp." (code "RBT") will
-- not supply any pieces (the provider should still remain in the database).
 DELETE FROM Provides
   WHERE Provider = 'RBT';
