
CREATE DATABASE [t1] ON  PRIMARY 
( NAME = N't2',
  FILENAME = N'C:\USERS\МИША\SOURCE\REPOS\EDUCATION\SQLSAMPLES\SAMPLES\t3.mdf')

  DROP DATABASE t1;

SELECT *
FROM sys.databases

CREATE TABLE Persons
(
PersonID int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);

INSERT INTO Role (Code, Name)
VALUES ('admin', 'Администратор')

DELETE FROM User1
WHERE ID =1


update TableTest set first = 'update' where id = 3
select * from TableTest