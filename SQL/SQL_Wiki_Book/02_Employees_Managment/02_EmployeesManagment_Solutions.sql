CREATE DATABASE [EmployeeManagement]
GO

USE [EmployeeManagement]
GO

CREATE TABLE [Departments]
(
	Code INT PRIMARY KEY,
	[Name] VARChAR(255) NOT NULL,
	Budget DECIMAL NOT NULL
);

CREATE TABLE [Employees]
(
	SSN INT PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	Department INT NOT NULL,
	CONSTRAINT fk_Departments_Code
	FOREIGN KEY (Department) REFERENCES Departments(Code)
);

INSERT INTO Departments(Code,Name,Budget) VALUES(14,'IT',65000);
INSERT INTO Departments(Code,Name,Budget) VALUES(37,'Accounting',15000);
INSERT INTO Departments(Code,Name,Budget) VALUES(59,'Human Resources',240000);
INSERT INTO Departments(Code,Name,Budget) VALUES(77,'Research',55000);

INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('123234877','Michael','Rogers',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('152934485','Anand','Manikutty',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('222364883','Carol','Smith',37);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('326587417','Joe','Stevens',37);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('332154719','Mary-Anne','Foster',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('332569843','George','O''Donnell',77);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('546523478','John','Doe',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('631231482','David','Smith',77);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('654873219','Zacary','Efron',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('745685214','Eric','Goldsmith',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('845657245','Elizabeth','Doe',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('845657246','Kumar','Swamy',14);

SELECT LastName FROM Employees

SELECT DISTINCT LastName From Employees

SELECT * FROM Employees Where LastName = 'Smith';

SELECT * FROM Employees Where LastName = 'Smith' OR LastName = 'Doe'

SELECT * FROM Employees Where Department = 14;

SELECT * FROM Employees Where Department IN (37, 77);

SELECT * FROM Employees Where LastName LIKE 'S%';

SELECT SUM(Budget) FROM Departments

SELECT d.Code, COUNT(*) FROM Employees AS e
 JOIN Departments AS d 
	ON (e.Department = d.Code)
		GROUP BY d.Code

SELECT * 
FROM Employees, Departments
WHERE Employees.Department = Departments.Code

SELECT E.Name AS 'Employee Name',
	   E.LastName As 'Employee Last Name',
	   D.Name AS 'Department Name',
	   D.Budget AS 'Budget'
	   FROM Employees AS E
		JOIN Departments AS D
		ON E.Department = d.Code

SELECT E.Name,
		E.LastName
		FROM Employees AS E
		JOIN Departments AS D
		ON E.Department = D.Code
			WHERE D.Budget > 60000

SELECT * 
FROM Departments AS D
Where D.Budget >
(
	SELECT AVG(Budget) FROM Departments
)

SELECT Name FROM Departments
WHERE Code IN
(
	SELECT Department FROM Employees
	GROUP BY Department
	Having Count(*) > 2
)

SELECT Name, LastName 
FROM Employees 
WHERE Department IN (
  SELECT Code 
  FROM Departments 
  WHERE Budget = (
    SELECT TOP 1 Budget 
    FROM Departments 
    WHERE Budget IN (
      SELECT DISTINCT TOP 2 Budget 
      FROM Departments 
     ORDER BY Budget ASC
    ) 
    ORDER BY Budget DESC
  )
);

INSERT INTO Departments
(
	Code,
	Name,
	Budget
)
VALUES 
(
	11,
	'Quality Assurance',
	40000
);

INSERT INTO Employees
(
	SSN,
	Name,
	LastName,
	Department
)
VALUES 
(
	847-21-9811,
	'Mary',
	'Moore',
	11
)

UPDATE  Departments
	SET Budget =  Budget * 0.9; 

UPDATE Employees
	SET Department = 14 Where Department = 77

DELETE FROM Employees
	Where Department IN
	(
		SELECT Code FROM Departments WHERE Budget >= 60000
	)

DELETE FROM Employees