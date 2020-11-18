Create Database Bookshop

use Bookshop

Create table Book(
Id INT NOT NULL IDENTITY Primary key,
Name nvarchar(MAX) NOT NULL CHECK (LEN(Name)>0),
Description nvarchar(MAX) NOT NULL CHECK (LEN(Description)>0)
)

Create table Author (
Id INT NOT NULL IDENTITY Primary key,
Name nvarchar(MAX) NOT NULL CHECK(LEN(Name)>0),
Address nvarchar(MAX) CHECK(LEN(Address) > 0)
)

Create table BookAuthor (
Id INT NOT NULL IDENTITY Primary key,
BookId INT NOT NULL FOREIGN KEY (BookId) REFERENCES Book(Id),
AuthorId INT NOT NULL FOREIGN KEY (AuthorId) REFERENCES Author(Id)
)

Create table BookForSale(
Id INT NOT NULL Primary key,
Price money NOT NULL CHECK(Price > 0),
Date date NOT NULL DEFAULT GETDATE(),
Amount INT NOT NULL CHECK(Amount >= 0),
CONSTRAINT FK_BOOK_ID FOREIGN KEY (Id) REFERENCES Book(Id)
)

INSERT INTO Book (Name, Description) VALUES ('Harry Potter', 'Fantastic description of magicians')
INSERT INTO Book (Name, Description) VALUES ('Faust', 'Poems about meeting the devil')
INSERT INTO Book (Name, Description) VALUES ('History of Ukraine', 'Detailed description of the story')
INSERT INTO Book (Name, Description) VALUES ('Hercule Poirot', 'Stories about an outstanding detective')
INSERT INTO Book (Name, Description) VALUES ('War and peace', 'A novel about love')
INSERT INTO Book (Name, Description) VALUES ('Basics of astronomy', 'Fundamentals of astronomy for schoolchildren')
INSERT INTO Book (Name, Description) VALUES ('Software basics', 'Basics of software for beginners')

INSERT INTO Author (Name, Address) VALUES ('Gete', 'Other words')
INSERT INTO Author (Name, Address) VALUES ('Joan Rowling', 'England ')
INSERT INTO Author (Name, Address) VALUES ('Grushevsky', 'Some other address')
INSERT INTO Author (Name, Address) VALUES ('Agatha Kristi', 'Scotland')
INSERT INTO Author (Name, Address) VALUES ('Shevchenko', 'Word of freedom')
INSERT INTO Author (Name, Address) VALUES ('Larrson', 'USA')
INSERT INTO Author (Name, Address) VALUES ('Peters', 'Canada')
INSERT INTO Author (Name, Address) VALUES ('Levchenko', 'Ukraine')
INSERT INTO Author (Name, Address) VALUES ('Stoler', 'Mexico')

INSERT INTO BookAuthor (bookId, AuthorId) VALUES (1,1)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (2,2)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (3,3)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (4,4)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (5,5)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (6,6)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (7,7)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (7,8)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (5,9)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (2,3)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (5,5)
INSERT INTO BookAuthor (bookId, AuthorId) VALUES (3,1)

INSERT INTO BookForSale (Id, Price, Amount) VALUES (1, 100, 10)
INSERT INTO BookForSale (Id, Price, Amount) VALUES (2, 200, 15)
INSERT INTO BookForSale (Id, Price, Amount) VALUES (3, 300, 50)
INSERT INTO BookForSale (Id, Price, Amount) VALUES (4, 400, 200)
INSERT INTO BookForSale (Id, Price, Amount) VALUES (5, 500, 125)

--all books of first author
Select b.Name as [Name og book] from Book as b
join BookAuthor as ba on b.Id=ba.BookId
join Author as a on ba.AuthorId=a.Id
where a.Id=1

--count of books in sale
Select count(Id) as [Total sale] from BookForSale as bs

-- a books whose had 2 or more authors
SELECT b.Name as [Name og book], b.Description as [Descript] FROM Book as b
join BookAuthor as ba on ba.bookId = b.Id
join Author as a on ba.AuthorId = a.Id
Group by b.Name,b.Description
HAVING COUNT(a.Id) > 2

--AVG price book that have an author Gete
Select AVG(Price) as [Price] from BookForSale as bfs
join Book as b on bfs.Id=b.Id
join BookAuthor as ba on b.Id=ba.BookId
join Author as a on ba.AuthorId=a.Id
where a.Name='Gete'

-- authors of book 'Faust'
Select a.Name as [Name of author] from Book as b
join BookAuthor as ba on b.Id=ba.BookId
join Author as a on ba.AuthorId=a.Id
where b.Name='Faust'


