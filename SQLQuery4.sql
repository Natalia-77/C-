CREATE DATABASE Academy

use Academy

CREATE TABLE Departments (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Financing money NOT NULL CHECK( Financing>=0 ) DEFAULT 0,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

CREATE TABLE Faculties(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Dean nvarchar(MAX) NOT NULL CHECK (LEN(Dean)>0),
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

CREATE TABLE Groups(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(10) NOT NULL CHECK (LEN(Name)>0) UNIQUE,
Rating INT NOT NULL CHECK(Rating>=0 AND Rating <=5),
Year INT NOT NULL CHECK(Year>0 AND Year <=5)
)

CREATE TABLE Teachers(
Id INT NOT NULL IDENTITY PRIMARY KEY,
EmploymentDate date NOT NULL CHECK (EmploymentDate >'1990-01-01'),
IsAssistant bit NOT NULL DEFAULT 0,
IsProfessor bit NOT NULL DEFAULT 0,
Name nvarchar(10) NOT NULL CHECK(LEN(NAME)>0),
Position nvarchar(10)NOT NULL CHECK(LEN(Position)>0),
Premium money NOT NULL CHECK(Premium>=0) DEFAULT 0,
Salary money NOT NULL CHECK (Salary>0),
Surname nvarchar(MAX) NOT NULL CHECK(LEN(Surname)>0)
)

INSERT INTO Departments (Financing, Name) VALUES (20000, 'Politeconomy')
INSERT INTO Departments (Financing, Name) VALUES (30000, 'History')
INSERT INTO Departments (Financing, Name) VALUES (70000, 'Audit')
INSERT INTO Departments (Financing, Name) VALUES (50000, 'Macroeconomy')
INSERT INTO Departments (Financing, Name) VALUES (25000, 'Politology')
INSERT INTO Departments (Financing, Name) VALUES (30000, 'Law')

INSERT INTO Faculties (Dean, Name) VALUES ('Gryshevsky', 'Economy')
INSERT INTO Faculties (Dean, Name) VALUES ('Shevchenko', 'Microeconomy')
INSERT INTO Faculties (Dean, Name) VALUES ('Petlura', 'Historical')
INSERT INTO Faculties (Dean, Name) VALUES ('Bandera', 'Macroeconomical')
INSERT INTO Faculties (Dean, Name) VALUES ('Shukhevich', 'Laws')
INSERT INTO Faculties (Dean, Name) VALUES ('Petrov', 'Auditing')


INSERT INTO Groups (Name, Rating, Year) VALUES ('PUU-111', 3, 2)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PUU-231', 4, 4)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PPU-121', 4, 1)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PRU-963', 2, 1)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PPU-225', 1, 4)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PPU-458', 2, 3)
INSERT INTO Groups (Name, Rating, Year) VALUES ('PPU-588', 1, 3)

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2015-03-05', 0, 1, 'Ivan', 'Professor', 500, 20000, 'Ivanov')

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2000-10-13', 1, 0, 'Viktoria', 'Assistant', 100, 4000, 'Kurochka')

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('1999-12-10', 0, 1, 'Sanyor', 'Professor', 600, 18000, 'Orel')

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2019-11-19', 1, 0, 'Maria', 'Assistant', 100, 5000, 'Malva')

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2020-02-12', 0, 1, 'Victor', 'Professor', 2000, 19000, 'Pavlic')

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2018-05-01', 0, 1, 'Marat', 'Assistant', 100, 6000, 'Basharov')


--1.
Select Name from Departments 
ORDER BY Name DESC
--2.
SELECT Name+'-->'+CAST(Rating as nvarchar) as [Total]
FROM Groups
--3.
SELECT Surname , (Salary + Premium) as [Total Sum],
((Premium/Salary)*100) as [Persent] FROM Teachers
--4.
SELECT ('The dean of faculty ' + Name + ' is ' + Dean) as [Total table]
FROM Faculties
--5.
Select Surname  From Teachers
WHERE (IsProfessor=1 AND Salary>5500)
--6.
Select Name From Departments
WHERE (Financing>11000 OR Financing<20000)
--7.
Select Name from Faculties
WHERE Name<>'Laws'
--8.
Select Name,Position FROM Teachers
Where IsProfessor=0;
--9.
SELECT Surname, Position, Salary, Premium 
FROM Teachers
WHERE( IsAssistant=1 AND Premium >= 60 AND Premium <= 550)
--10.
Select Name as[Name of assistant],
Salary as [Salary]
From Teachers
Where Position LIKE 'Assistant'
--11.
Select Surname,Name 
From Teachers
Where EmploymentDate < '2000-01-01'
--12.
Select Name as [Name of Department]
From Departments
Where Name<'Macroeconomy'
Order By Name
--13.
Select Surname 
From Teachers
Where ((CAST(Salary as int)+CAST(Premium as int))>1200 AND IsAssistant=1)
--14.
Select Name as [Name of group]
From Groups
Where (Year=1 AND (Rating>=2 AND Rating<=4))
--15.
Select Surname as [Surname of assistance]
From Teachers
Where (IsAssistant=1 AND(Salary <550 OR Premium<220))