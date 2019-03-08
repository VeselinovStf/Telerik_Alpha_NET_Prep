--CREATE DATABASE TheWarehouse
--GO

USE TheWarehouse
GO

-- CREATE TABLE Warehouses (
--   Code INTEGER PRIMARY KEY NOT NULL,
--   Location TEXT NOT NULL ,
--   Capacity INTEGER NOT NULL 
-- );
 
-- CREATE TABLE Boxes (
--   Code VARCHAR(4) PRIMARY KEY NOT NULL,
--   Contents TEXT NOT NULL ,
--   Value REAL NOT NULL ,
--   Warehouse INTEGER NOT NULL, 
--   CONSTRAINT fk_Warehouses_Code 
--   FOREIGN KEY (Warehouse) 
--   REFERENCES Warehouses(Code)
-- );

--INSERT INTO Warehouses(Code,Location,Capacity) VALUES(1,'Chicago',3);
-- INSERT INTO Warehouses(Code,Location,Capacity) VALUES(2,'Chicago',4);
-- INSERT INTO Warehouses(Code,Location,Capacity) VALUES(3,'New York',7);
-- INSERT INTO Warehouses(Code,Location,Capacity) VALUES(4,'Los Angeles',2);
-- INSERT INTO Warehouses(Code,Location,Capacity) VALUES(5,'San Francisco',8);

--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('0MN7','Rocks',180,3);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('4H8P','Rocks',250,1);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('4RT3','Scissors',190,4);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('7G3H','Rocks',200,1);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('8JN6','Papers',75,1);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('8Y6U','Papers',50,3);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('9J6F','Papers',175,2);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('LL08','Rocks',140,4);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('P0H6','Scissors',125,1);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('P2T6','Scissors',150,2);
--INSERT INTO Boxes(Code,Contents,Value,Warehouse) VALUES('TU55','Papers',90,5);

--SELECT * FROM Warehouses

--SELECT * FROM Boxes WHERE Value > 150

--SELECT DISTINCT Contents FROM Boxes

--SELECT AVG(Value) FROM Boxes

--SELECT Warehouse, AVG(Value)
--FROM Boxes
--GROUP BY Warehouse

--SELECT Warehouse, AVG(Value)
--FROM Boxes
--GROUP BY Warehouse
--HAVING AVG(Value) > 150

--SELECT B.Code, Location FROM Boxes AS B
--JOIN Warehouses AS W
--	ON B.Warehouse = W.Code 

 --SELECT Warehouse, COUNT(*)
 --FROM Boxes
 --GROUP BY Warehouse;

 --SELECT Warehouses.Code, COUNT(Boxes.Code)
 --FROM Warehouses LEFT JOIN Boxes
 --  ON Warehouses.Code = Boxes.Warehouse
 --GROUP BY Warehouses.Code;

--SELECT Code FROM Warehouses 
--	WHERE Capacity < 
--	(
--		SELECT COUNT(*)
--		FROM Boxes
--		WHERE Warehouse = Warehouses.Code
--	)

 --INSERT INTO Warehouses
 --(
	--Code,
	--Location,
	--Capacity
 --)
 --VALUES 
 --(
	--6,
	--'New York',
	--3
 --);

 --INSERT INTO Boxes 
	-- ( Code , Contents, Value, Warehouse)
	-- Values
	-- ( 'H5RT', 'Papers',200,2)

--UPDATE Boxes
--	SET Value = Value * 0.85;

--UPDATE Boxes
--	Set Value = Value * 0.80
--	WHERE Value > (SELECT AVG(Value) From Boxes)

--DELETE FROM Boxes WHERE Value < 100

DELETE FROM Boxes WHERE Warehouse IN
( 
SELECT Code
       FROM Warehouses
       WHERE Capacity <
       (
         SELECT COUNT(*)
           FROM Boxes
           WHERE Warehouse = Warehouses.Code
       )
)