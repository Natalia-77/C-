CREATE DATABASE Academi
use Academi

CREATE TABLE Curators (
Id int NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name) > 0),
Surname nvarchar(MAX) NOT NULL CHECK(LEN(Surname) > 0)
)

CREATE TABLE Faculties (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(100) NOT NULL CHECK(LEN(Name) > 0) UNIQUE
)

CREATE TABLE Departments (
Id INT NOT NULL PRIMARY KEY IDENTITY,
Building INT NOT NULL CHECK(Building >= 1 AND Building <= 5),
Financing money NOT NULL CHECK(Financing >= 0) DEFAULT 0,
Name nvarchar(100) NOT NULL CHECK(LEN(Name) > 0) UNIQUE,
FacultyId INT NOT NULL FOREIGN KEY (FacultyId) REFERENCES Faculties(Id)
)

CREATE TABLE Groups (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(10) NOT NULL CHECK(LEN(Name) > 0) UNIQUE,
Year INT NOT NULL CHECK (Year >= 1 AND Year <= 5),
DepartmentId INT NOT NULL FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
)

CREATE TABLE GroupsCurators (
Id INT NOT NULL IDENTITY PRIMARY KEY,
CuratorId INT NOT NULL FOREIGN KEY (CuratorId) REFERENCES Curators(Id),
GroupId INT NOT NULL FOREIGN KEY (GroupId) REFERENCES Groups(Id)
)

CREATE TABLE Subjects (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(100) NOT NULL CHECK(LEN(Name) > 0) UNIQUE
)

CREATE TABLE Teachers (
Id INT NOT NULL IDENTITY PRIMARY KEY,
IsProfessor bit NOT NULL DEFAULT 0,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name) > 0),
Salary MONEY NOT NULL CHECK(Salary > 0),
Surname NVARCHAR(MAX) NOT NULL CHECK(LEN(Surname) > 0)
)

CREATE TABLE Lectures (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Date date NOT NULL CHECK(Date > GETDATE()),
SubjectId INT NOT NULL FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
TeacherId INT NOT NULL FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
)

CREATE TABLE Students (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name) > 0),
Rating INT NOT NULL CHECK(Rating >= 0 AND Rating <= 5),
Surname NVARCHAR(MAX) NOT NULL CHECK(LEN(Surname) > 0)
)

CREATE TABLE GroupsLectures (
Id INT NOT NULL IDENTITY PRIMARY KEY,
GroupId INT NOT NULL FOREIGN KEY (GroupId) REFERENCES Groups(Id),
LectureId INT NOT NULL FOREIGN KEY (LectureId) REFERENCES Lectures(Id)
)

CREATE TABLE GroupsStudents (
Id INT NOT NULL IDENTITY PRIMARY KEY,
GroupId INT NOT NULL FOREIGN KEY (GroupId) REFERENCES Groups(Id),
StudentId INT NOT NULL FOREIGN KEY (StudentId) REFERENCES Students(Id)
)

--delete from GroupsCurators
--delete from Curators
--delete from Faculties
--delete from Departments
--delete from Groups
--delete from Subjects
--delete from Teachers
--delete from Lectures
--delete from Students
--delete from GroupsLectures
--delete from GroupsStudents

INSERT INTO Curators (Name, Surname) VALUES ('Ilon', 'Mask')
INSERT INTO Curators (Name, Surname) VALUES ('Donald', 'Trump')
INSERT INTO Curators (Name, Surname) VALUES ('Kim', 'Chen')

INSERT INTO Faculties (Name) VALUES ('Computer Science')
INSERT INTO Faculties (Name) VALUES ('Design')
INSERT INTO Faculties (Name) VALUES ('Cyber')

INSERT INTO Departments (Building, Financing, Name, FacultyId) VALUES (2, 200000, 'Software Development', 4)
INSERT INTO Departments (Building, Financing, Name, FacultyId) VALUES (4, 300000, 'Pattern design', 5)
INSERT INTO Departments (Building, Financing, Name, FacultyId) VALUES (1, 330000, 'Huperloop', 6)

INSERT INTO Groups (Name, Year, DepartmentId) VALUES ('YU225', 3, 7)
INSERT INTO Groups (Name, Year, DepartmentId) VALUES ('YU121', 1, 8)
INSERT INTO Groups (Name, Year, DepartmentId) VALUES ('YU555', 4, 9)

INSERT INTO GroupsCurators (CuratorId, GroupId) VALUES (4,6)
INSERT INTO GroupsCurators (CuratorId, GroupId) VALUES (5,5)
INSERT INTO GroupsCurators (CuratorId, GroupId) VALUES (6,4)

INSERT INTO Subjects (Name) VALUES ('Green')
INSERT INTO Subjects (Name) VALUES ('Red')
INSERT INTO Subjects (Name) VALUES ('Black')

INSERT INTO Teachers (IsProfessor, Name, Salary, Surname) VALUES (1, 'Mario', 25000, 'Martor')
INSERT INTO Teachers (IsProfessor, Name, Salary, Surname) VALUES (1, 'Misha', 30000, 'Partoy')
INSERT INTO Teachers (IsProfessor, Name, Salary, Surname) VALUES (0, 'Lava', 35000, 'Cool')

INSERT INTO Lectures (Date, SubjectId, TeacherId) VALUES (GETDATE() + DATEADD(hh, 1, current_timestamp), 4, 4)
INSERT INTO Lectures (Date, SubjectId, TeacherId) VALUES (GETDATE() + DATEADD(hh, 1, current_timestamp), 5, 6)
INSERT INTO Lectures (Date, SubjectId, TeacherId) VALUES (GETDATE() + DATEADD(hh, 1, current_timestamp), 6, 5)

INSERT INTO Students (Name, Rating, Surname) VALUES ('Sergey', 3, 'Serenko')
INSERT INTO Students (Name, Rating, Surname) VALUES ('Maria', 4, 'Ivanova')
INSERT INTO Students (Name, Rating, Surname) VALUES ('Oleg', 5, 'Redko')

INSERT INTO GroupsLectures (GroupId, LectureId) VALUES (4,4)
INSERT INTO GroupsLectures (GroupId, LectureId) VALUES (5,5)
INSERT INTO GroupsLectures (GroupId, LectureId) VALUES (6,6)

INSERT INTO GroupsStudents (GroupId, StudentId) VALUES (4,6)
INSERT INTO GroupsStudents (GroupId, StudentId) VALUES (5,5)
INSERT INTO GroupsStudents (GroupId, StudentId) VALUES (6,4)

--1.Вывести номера корпусов, если суммарный фонд финансирования расположенных в них кафедр превышает 10000
Select Building as [Numbers of building] from Departments as dep
where dep.Financing>10000

--2.Вывести названия групп 3-го курса кафедры “Software Development”.
Select g.Name as [Name of group] from Groups as g
join Departments as dep on g.DepartmentId=dep.Id
where dep.Name='Software Development' and g.Year=3

--3.Вывести названия групп, имеющих рейтинг (средний рей-
--тинг всех студентов группы) менше, чем рейтинг группы “YU225”.
Select g.Name as [Name of group] from Groups as g
join GroupsStudents as gst on g.Id=gst.GroupId
join Students as s on gst.StudentId=s.Id
Group by g.Name
HAVING AVG(s.Rating)<(Select AVG(s.Rating) from Groups as g 
join GroupsStudents as gst on g.Id=gst.GroupId
join Students as s on gst.StudentId=s.Id
where g.Name='YU225'
Group by g.Name)

--4.Вывести фамилии и имена преподавателей, ставка которых ниже средней ставки профессоров.
Select (Surname+' '+Name) as [Professors] from Teachers as tea 
where tea.Salary<(Select AVG(Salary)from Teachers where tea.IsProfessor=1)

--5.Вывести названия групп, у которых один куратор.
Select g.Name as [Group Name] from Groups as g
join GroupsCurators as gc on g.Id=gc.GroupId
join Curators as c on gc.CuratorId=c.Id
Group by g.Name
Having count(c.Id)=1

--6.Вывести названия групп, имеющих рейтинг (средний рей-
--тинг всех студентов группы) меньше, чем минимальный рейтинг групп 3-го курса.
Select g.Name as [Name of groups] from Groups as g
join GroupsStudents as gst on g.Id=gst.GroupId
join Students as s on gst.StudentId=s.Id
Group by g.Name
Having AVG(s.Rating)<(Select MIN(Rating) from Students as stud
join GroupsStudents as gr on stud.Id=gr.StudentId
join Groups as grup on gr.GroupId=grup.Id
where grup.Year=3)

--7.Вывести названия факультетов, суммарный фонд финансирования кафедр которых больше суммарного фонда
--финансирования кафедр факультета “Computer Science”.
Select f.Name as [Name of faculties] from Faculties as f
join Departments as d on f.Id=d.FacultyId
Group by f.Name
Having SUM(d.Financing)>(Select SUM(dep.Financing) from Departments as dep
join Faculties as fa on dep.FacultyId=fa.Id
where fa.Name ='Computer Science')

--8.Вывести названия дисциплин и полные имена преподавателей, читающих наибольшее количество лекций по ним.
Select (tea.Surname+' '+tea.Name) as [Teachers] ,Count(lec.Id) as [Count] from Subjects as s
join Lectures as lec on s.Id=lec.SubjectId
join Teachers as tea on lec.TeacherId=tea.Id
Group by tea.Name,tea.Surname,lec.Id
HAVING count (lec.Id)=(Select MAX(r.count) from (Select count(lec.Id) as [count] FROM Subjects as s 
join Lectures as l on l.SubjectId = s.Id 
join Teachers as t on l.TeacherId = t.Id 
GROUP BY s.Name) as r)

--9.Вывести название дисциплины, по которому читается меньше всего лекций.
Select s.Name as [Name subject],count (l.Id) as [Counts] from Subjects as s
join Lectures as l on s.Id=l.SubjectId
join Teachers as tea on l.TeacherId=tea.Id
Group by s.Name
Having count(l.Id)=(Select MIN(r.count) from(Select count(l.Id) as [count] from Subjects as s 
join Lectures as l on l.SubjectId = s.Id 
join Teachers as t on l.TeacherId = t.Id 
GROUP BY s.Name) as r)

--10.Вывести количество студентов и читаемых дисциплин на кафедре “Software Development”.
Select count(st.Id) as [Count of students], count(s.Id) as [Count of subjects] FROM Departments as dep
JOIN Groups as g on g.DepartmentId = dep.Id
JOIN GroupsStudents as gs on gs.GroupId = g.Id
JOIN Students as st on st.Id = gs.StudentId
JOIN GroupsLectures as gl on gl.GroupId = g.Id
JOIN Lectures as lec on lec.Id = gl.LectureId
JOIN Subjects as s on s.Id = lec.SubjectId
WHERE dep.Name = 'Software Development'
