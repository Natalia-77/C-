Create database Hospitale

use Hospitale

Create table Departments(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Building INT NOT NULL CHECK(Building>=1 AND Building <=5),
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

Create table Doctors(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name)>0),
Premium money NOT NULL CHECK(Premium>0) DEFAULT 0,
Salary money NOT NULL CHECK(Salary>0),
Surname nvarchar(MAX) NOT NULL CHECK (LEN(Surname)>0)
)

Create table Examinations(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)

Create table Wards(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(20) NOT NULL CHECK(LEN(Name)>0) UNIQUE,
Places INt NOT NULL CHECK(Places>0),
DepartmentId INT NOT NULL Foreign Key (DepartmentId) References Departments(Id)
)


Create table DoctorsExaminations(
Id INT NOT NULL IDENTITY PRIMARY KEY,
StartTime  time NOT NULL CHECK(StartTime>'8:00' AND StartTime<'18:00'),
EndTime time NOT NULL ,
Constraint Check_StartEndTime CHECK(EndTime>StartTime),
DoctorId INT NOT NULL Foreign Key (DoctorId) References Doctors(Id),
ExaminationId INt NOT NULL  Foreign key(ExaminationId) References Examinations(Id),
WardId INT NOT NULL Foreign key (WardId)References Wards(Id)
)

Create table Sponsor(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)



Create table Donations(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Amount money NOT NULL CHECK(Amount>0),
--Date date NOT NULL CHECK(Date > GETDATE()) DEFAULT GETDATE(), 
Date date CHECK (Date<Current_Timestamp)DEFAULT CURRENT_TIMESTAMP,
DepartmentId INT NOT NULL Foreign key (DepartmentId)References Departments(Id),
SponsorId INT NOT NULL Foreign key (SponsorId)References Sponsor(Id)
)

INSERT INTO Departments(Building,Name)VALUES(1,'Cardiology')
INSERT INTO Departments(Building,Name)VALUES(2,'Gastroenterology')
INSERT INTO Departments(Building,Name)VALUES(3,'General surgery')
INSERT INTO Departments(Building,Name)VALUES(4,'Microbiology')
INSERT INTO Departments(Building,Name)VALUES(5,'Neurology')
--delete  from Departments
--DROP table Donations;
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Ivan',500,8500,'Petrenko')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Oleg',350,7600,'Golovko')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Petro',200,9200,'Petrik')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Marina',800,10000,'Sidorenko')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Anthony',400,9500,'Davis')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Joshua',200,18500,'Bell')
INSERT INTO Doctors(Name,Premium,Salary,Surname)VALUES('Thomas',300,15000,'Gerada')

INSERT INTO Examinations(Name)VALUES('UZD')
INSERT INTO Examinations(Name)VALUES('Blood')
INSERT INTO Examinations(Name)VALUES('Pochesatu sninu')
INSERT INTO Examinations(Name)VALUES('Pomutu golovu')
INSERT INTO Examinations(Name)VALUES('Zrovutu strishky')
INSERT INTO Examinations(Name)VALUES('Zrobitu manikur')
INSERT INTO Examinations(Name)VALUES('Prokolotu vyho')

INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Green',5,7)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Yellow',8,8)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Red',10,9)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Black',3,10)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('White',4,11)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Blue',9,7)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Cyan',7,9)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Navy',7,8)
INSERT INTO Wards(Name,Places,DepartmentId)VALUES ('Gold',6,9)


INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('8:45','10:00',1,1,2)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('9:25','12:00',2,3,3)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('9:50','11:30',3,2,2)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('12:45','15:00',4,2,4)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('13:55','17:00',5,6,5)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('10:45','13:20',6,7,5)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('11:15','16:25',7,4,6)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('16:45','17:30',6,1,1)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('12:12','14:00',5,2,1)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('17:45','17:55',4,4,8)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('9:00','10:00',3,5,8)
INSERT INTO DoctorsExaminations(StartTime,EndTime,DoctorId,ExaminationId,WardId)VALUES('15:20','17:00',1,5,9)

INSERT INTO Sponsor(Name)VALUES('Trump')
INSERT INTO Sponsor(Name)VALUES('Sarcozy')
INSERT INTO Sponsor(Name)VALUES('Merkel')
INSERT INTO Sponsor(Name)VALUES('Kim Chen In')
INSERT INTO Sponsor(Name)VALUES('Zelenskyi')
INSERT INTO Sponsor(Name)VALUES('Duda')
INSERT INTO Sponsor(Name)VALUES('Erdogan')
INSERT INTO Sponsor(Name)VALUES('Yakihito')


INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(20000,'2020-10-12',7,1)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(30000,'2020-11-02',8,2)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(40000,'2020-09-02',9,3)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(50000,'2020-10-02',10,4)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(60000,'2020-09-05',11,5)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(70000,'2020-10-05',9,6)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(80000,'2020-05-05',7,7)
INSERT INTO Donations(Amount,Date,DepartmentId,SponsorId)VALUES(90000,'2020-06-05',8,8)

--1.¬ывести названи€ отделений, что наход€тс€ в том же корпусе, что и отделение УCardiologyФ.

Select Departments.Building as[Number of department],Departments.Name as[Name]
from Departments
where Departments.Building in
(Select Departments.Building Departments where Departments.Name='Cardiology')

--2.¬ывести названи€ отделений, что наход€тс€ в том же корпусе, что и 
--отделени€ УGastroenterologyФ и УGeneral SurgeryФ.

Select Departments.Building as[Number of department],Departments.Name as[Name]
from Departments
where Departments.Building in
(Select Departments.Building Departments where Departments.Name='Cardiology' 
or Departments.Name='General Surgery')

--3. ¬ывести название отделени€, которое получило меньше
--всего пожертвований.
Select Departments.Name as [Name] from Departments
join Donations as d on Departments.Id=d.DepartmentId
where d.Amount=(Select MIN(Amount)from Donations)

--4.¬ывести фамилии врачей, ставка которых больше, чем у врача УThomas GeradaФ.
Select Name as[Name],Surname as[Surname] 
from Doctors
Where Doctors.Salary>(Select Salary from Doctors where Name='Thomas')

--5.¬ывести названи€ палат, вместимость которых больше,
--чем средн€€ вместимость в палатах отделени€ УMicrobiologyФ.
Select Name as [Name of ward]from Wards as w
where w.Places>(Select AVG(Places)from Wards as w join Departments as d on w.DepartmentId=d.Id
AND d.Name='Microbiology')

--6.¬ывести полные имена врачей, зарплаты которых (сумма ставки и надбавки) превышают более чем на 100 зарплату
--врача УAnthony DavisФ.
select (Name+' '+Surname) as [Names] from Doctors as doc
where (Salary+Premium)>(Select (Salary+Premium) from Doctors where Name='Anthony')
group by doc.Name,doc.Surname


--7.¬ывести названи€ отделений, в которых проводит обследовани€ врач УJoshua BellФ.
Select dept.Name as [Name of department] from Departments as dept
join Wards as war on dept.Id=war.DepartmentId
join DoctorsExaminations as d on war.Id=d.WardId
join Doctors as doct on d.DoctorId=doct.Id
Where doct.Name='Joshua'
Group by dept.Name

--8.¬ывести названи€ спонсоров, которые не делали пожертвовани€
--отделени€м УNeurologyФ и УOncologyФ.
Select s.Name as [Sponsor] from Sponsor as s 
join Donations as d on s.Id=d.SponsorId
join Departments as dep on d.DepartmentId=dep.Id
where NOT dep.Name ='Neurology' AND NOT dep.Name='Cardiology' 
Group by s.Name

--9.¬ывести фамилии врачей, которые провод€т обследовани€ в период с 12:00 до 15:00.
Select Surname as [Doctors surname]from Doctors as doc
join DoctorsExaminations as docex on doc.Id=docex.DoctorId
where docex.StartTime between'12:00' and '15:00'
group by doc.Surname










