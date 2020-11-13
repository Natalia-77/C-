Create Database Hospital

use Hospital

create table Departments(
Id INT NOT NULL IDENTITY Primary key,
Building INT NOT NULL CHECK(Building>=1 AND Building <=5),
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

create table Doctors(
Id INT IDENTITY NOT NULL PRIMARY KEY,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name)>0),
Premium money NOT NULL CHECK(Premium>0) DEFAULT 0,
Salary money NOT NULL CHECK(Salary >0),
Surname nvarchar(MAX) NOT NULL CHECK(LEN(Surname)>0)
)
------
create table Wards(
Id INT Identity NOT NULL Primary Key,
Name nvarchar(20) NOt NULL CHECK(LEN(Name)>0) UNIQUE,
Places INT NOT NULL CHECK(Places>1),
DepartmentId INT NOT NULL Foreign Key (DepartmentId)References Departments(Id)
)

create table Examinations(
Id INT Identity NOT NULL Primary Key,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

create table DoctorsExaminations(
Id INT IDENTITY NOT NULL Primary KEY,
StartTime  time NOT NULL CHECK(StartTime>'8:00' AND StartTime<'18:00'),
EndTime time NOT NULL ,
Constraint Check_StartEndTime CHECK(EndTime>StartTime),
DoctorId INT NOT NULL Foreign Key (DoctorId) References Doctors(Id),
ExaminationId INt NOT NULL  Foreign key(ExaminationId) References Examinations(Id),
WardId INT NOT NULL Foreign key (WardId)References Wards(Id)
)

Delete from DoctorsExaminations


INSERT INTO Departments(Building,Name) VALUES(1,'Therapy');
INSERT INTO Departments(Building,Name) VALUES(2,'Cardiology');
INSERT INTO Departments(Building,Name) VALUES(3,'Stomatology');
INSERT INTO Departments(Building,Name) VALUES(4,'Patology');
INSERT INTO Departments(Building,Name) VALUES(5,'Urology');

INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Oleg',200,5000,'Vinnyk');
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Ivo',500,8000,'Bobul');
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Victor',800,9000,'Pavlic');
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Masha',280,15000,'Rasputina');
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Alla',100,50000,'Pugachova');

INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Green',5,1);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Red',10,1);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('White',4,2);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Black',4,3);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Yellow',3,2);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Blue',5,4);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Pink',3,5);
INSERT INTO Wards(Name,Places,DepartmentId)VALUES('Gold',4,5);

INSERT INTO Examinations(Name)Values('UZD');
INSERT INTO Examinations(Name)Values('Blood');
INSERT INTO Examinations(Name)Values('Pochesatu sninu');
INSERT INTO Examinations(Name)Values('Pomutu golovu');
INSERT INTO Examinations(Name)Values('Zrovutu strishky');
INSERT INTO Examinations(Name)Values('Zrobitu manikur');
INSERT INTO Examinations(Name)Values('Prokolotu vyho');
INSERT INTO Examinations(Name)Values('Zaspivatu pisniy');

INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('10:15','12:25',1,2,9);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('09:15','13:25',1,1,10);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('15:15','16:45',2,2,10);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('08:25','10:50',3,3,11);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('15:55','17:45',4,5,12);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('11:55','12:25',5,4,13);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('17:10','17:25',3,6,14);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('13:00','14:25',2,6,15);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('16:35','17:25',4,7,16);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('12:20','15:45',5,7,12);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('10:15','12:25',2,8,16);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('12:25','12:45',5,5,14);
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)Values('14:15','15:25',3,2,15);

--1.
Select count(*) as [Count res] 
from Wards where Places>5;

--2.
select Departments.Name as [Name] ,count(*) as [count] from Wards , Departments 
Where Departments.Id=Wards.DepartmentId
group by Departments.Name

--3.Вивести назви відділень і кількість палат в кожному з них.
select Departments.Building as [Build] ,count(*) as [count] from Wards , Departments 
Where Departments.Id=Wards.DepartmentId
group by Departments.Building

---4.Вивести назви  відділень  і сумарну надбавку лікарів в кожному з них.
select Departments.Name as[Name],Sum(Premium)as [count] from Doctors
join DoctorsExaminations as d on Doctors.Id=d.DoctorId
join Wards as w on d.WardId=w.Id
join Departments  on  w.DepartmentId=Departments.Id
Group by Departments.Name

--5.
select Departments.Name as[Name],count(*)as [count] from Doctors
join DoctorsExaminations as d on Doctors.Id=d.DoctorId
join Wards as w on d.WardId=w.Id
join Departments  on  w.DepartmentId=Departments.Id
Group by Departments.Name
Having Count(Doctors.Id)>2

--6.
Select count(*)as [Countdoctors] ,sum(Salary+Premium) as [Sum salary] from Doctors

--7.
select AVG(Salary+Premium) as Res from Doctors

--8.
Select Name as[Wardsname],MIN(Places) as [Res] from Wards
group by Wards.Name
having min(Places)<5

--9.Вывести в каких из корпусов 1, 6, 7 и 8, суммарное количе-
--ство мест в палатах превышает 100. При этом учитывать
--только палаты с количеством мест больше 3
Select b.Building,b.suma from
(select Departments.Building,SUM(w.Places) as suma
from Departments 
join Wards as w on w.DepartmentId=Departments.Id
where w.Places>3 AND Departments.Building=1 or Departments.Building=4
Group by Departments.Building)as b
where b.suma>4




