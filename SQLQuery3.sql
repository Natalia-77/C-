Create Database Academ

use Academ


create table Faculties(
Id int identity not null primary key,
Name nvarchar(100) not null check(len(name)>0) unique,
)

CREATE TABLE Departments (
Id INT NOT NULL IDENTITY PRIMARY KEY,
Financing money NOT NULL CHECK( Financing>=0 ) DEFAULT 0,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE,
FacultyId INT NOT NULL Foreign key(FacultyId) References Faculties (Id)
)

CREATE TABLE Groups(
Id INT IDENTITY NOT NULL PRIMARY KEY,
Name nvarchar(10) NOT NULL CHECK(len(Name)>0) UNIQUE,
Year INT NOT NULL CHECK(Year >=1 and Year <=5),
DepartmentId INT NOT NULL Foreign key(DepartmentId) References Departments (Id)
)


Create table Subjects(
Id INT IDENTITY NOT NULL PRIMARY KEY,
Name nvarchar(10) NOT NULL CHECK(len(Name)>0) UNIQUE
)

Create table Teachers(
Id INT IDENTITY NOT NULL PRIMARY KEY,
Name nvarchar(max) NOT NULL CHECK(LEN(Name)>0),
Surname nvarchar(max) NOT NULL CHECK(LEN(Surname)>0),
Salary money NOT NULL CHECK(Salary>0)
)


Create Table Lecture(
Id INT IDENTITY NOT NULL PRIMARY KEY,
Dayofweek INT NOT NULL CHECK(Dayofweek>=1 AND Dayofweek<=7),
Lectureroom nvarchar(max) NOT NULL CHECK(LEN(Lectureroom)>0),
SubjectId INT NOT NULL Foreign key(SubjectId) References Subjects (Id),
TeacherId INT NOT NULL Foreign Key(TeacherId) References Teachers (Id)
)



CREATE TABLE GroupsLectures(
Id INT NOT NULL IDENTITY PRIMARY KEY,
GroupsId INT NOT NULL Foreign key(GroupsId) References Groups (Id) ,
LectureId INT NOT NULL Foreign key(LectureId) References Lecture (Id)
)

Insert INTO Faculties(Name) VALUES ('Law')
Insert INTO Faculties(Name) VALUES ('Economical')
Insert INTO Faculties(Name) VALUES ('Geography')
Insert INTO Faculties(Name) VALUES ('Biology')
Insert INTO Faculties(Name) VALUES ('Psichology')
Insert INTO Faculties(Name) VALUES ('Sociology')

Insert Into Departments(Financing,Name,FacultyId)VALUES(20000,'Social work',6)
Insert Into Departments(Financing,Name,FacultyId)VALUES(15000,'Financing',2)
Insert Into Departments(Financing,Name,FacultyId)VALUES(32000,'History of law',1)
Insert Into Departments(Financing,Name,FacultyId)VALUES(21000,'Geodesycal',3)
Insert Into Departments(Financing,Name,FacultyId)VALUES(40000,'Chemistry',4)
Insert Into Departments(Financing,Name,FacultyId)VALUES(28000,'Practical psychology',5)

INSERT INTO Groups(Name,Year,DepartmentId)VALUES('PPU-123',2,1)
INSERT INTO Groups(Name,Year,DepartmentId)VALUES('PPU-235',3,2)
INSERT INTO Groups(Name,Year,DepartmentId)VALUES('PTT-885',4,3)
INSERT INTO Groups(Name,Year,DepartmentId)VALUES('FFI-994',1,5)
INSERT INTO Groups(Name,Year,DepartmentId)VALUES('HPU-833',2,4)
INSERT INTO Groups(Name,Year,DepartmentId)VALUES('EWU-023',4,6)

INSERT INTO Subjects(Name)VALUES('Audits')
INSERT INTO Subjects(Name)VALUES('Socials')
INSERT INTO Subjects(Name)VALUES('Organics')
INSERT INTO Subjects(Name)VALUES('Biologys')
INSERT INTO Subjects(Name)VALUES('Psychology')
INSERT INTO Subjects(Name)VALUES('Laws')

INSERT INTO Teachers(Name,Surname,Salary)Values('Petro','Lomakin',8000)
INSERT INTO Teachers(Name,Surname,Salary)Values('Pavlo','Yula',9000)
INSERT INTO Teachers(Name,Surname,Salary)Values('Marina','Poroshenko',10000)
INSERT INTO Teachers(Name,Surname,Salary)Values('Olena','Ivanova',6000)
INSERT INTO Teachers(Name,Surname,Salary)Values('Max','Gomon',32000)
INSERT INTO Teachers(Name,Surname,Salary)Values('Artem','Amelin',35000)

INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(1,'Green',1,1)
INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(3,'Red',1,2)
INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(2,'Yellow',4,1)
INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(5,'White',2,4)
INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(4,'Violet',3,6)
INSERT INTO Lecture(Dayofweek,Lectureroom,SubjectId,TeacherId)Values(6,'Cyan',5,5)

INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (2,3)
INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (1,1)
INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (3,2)
INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (4,6)
INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (6,5)
INSERT INTO GroupsLectures(GroupsId,LectureId)VALUES (5,4)

--Select * from Lecture

--1.
Select count(distinct Surname)as Total
from Teachers as tea
join Lecture as lect on tea.Id=lect.TeacherId
join GroupsLectures as g on lect.Id=g.LectureId
join Groups as p on g.GroupsId=p.Id
join Departments as dep on p.DepartmentId=dep.Id
where dep.Name='Financing'
--2.
Select count(*)as[Count of Lectures]
from Lecture as lec
inner join Teachers as tea on tea.Id=lec.TeacherId AND tea.Surname='Lomakin'
--3.
Select count(*) as [Count of Lectures]
from Lecture as lec
where lec.Lectureroom ='Green'
--4.
Select  Lectureroom as [Name of auditory],count(*)as [Result count]from Lecture as lec
join Subjects as sub on lec.SubjectId=sub.Id
Group by Lectureroom
--5.
Select count(*) as [Count result]
from Groups as grp
join GroupsLectures as gl on grp.Id=gl.GroupsId
join Lecture as lec on gl.LectureId=lec.Id
join Teachers as tea on lec.TeacherId=tea.Id
Where tea.Surname='Gomon'
--6.
Select AVG(Salary) as[Average salary] from Teachers as tea
join Lecture as lect on tea.Id=lect.TeacherId
join GroupsLectures as g on lect.Id=g.LectureId
join Groups as p on g.GroupsId=p.Id
join Departments as dep on p.DepartmentId=dep.Id
join Faculties as fac on dep.FacultyId=fac.Id
where fac.Name='Law'
--7.
Select MIN(Salary) as [Minimal]
from Teachers
--8.
Select AVG(Financing) as [AVG of Department]
from Departments
--9.
Select Teachers.Surname as [Syrname of teachers],count(*)as [Count of subjects]
from Teachers,Subjects,Lecture
Where Subjects.Id=Lecture.SubjectId AND Lecture.TeacherId=Teachers.Id
Group by Teachers.Surname
--10.
Select Lecture.Dayofweek as [Day],
count (distinct Lecture.Dayofweek) as [Count of days] from Lecture
Group by Lecture.Dayofweek
--11.
Select Lecture.Lectureroom as [Name of auditory],count(*)as [Count of departments]
from Lecture,Departments,Groups,GroupsLectures
Where Departments.Id=Groups.DepartmentId AND Groups.Id=GroupsLectures.GroupsId AND
GroupsLectures.LectureId=Lecture.Id
Group by Lecture.Lectureroom
--12.
Select Faculties.Name as [Faculty names],count(*)as [Count of subjects]
from Faculties,Departments,Groups,GroupsLectures,Lecture,Subjects
Where Subjects.Id=Lecture.SubjectId AND Lecture.Id=GroupsLectures.LectureId AND
GroupsLectures.GroupsId=Groups.Id AND Groups.DepartmentId=Departments.Id AND
Departments.FacultyId=Faculties.Id
Group by Faculties.Name
--13.
Select (Teachers.Surname+' '+Teachers.Name+'-->'+Lecture.Lectureroom) as Result,count(*) as [Count]
from Lecture,Teachers
Where Lecture.TeacherId=Teachers.Id
Group by Teachers.Surname,Teachers.Name,Lecture.Lectureroom









