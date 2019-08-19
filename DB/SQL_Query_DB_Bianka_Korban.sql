CREATE DATABASE DB_Employee_Work_Hours

USE DB_Employee_Work_Hours
Create Table Employees(
EmpID int not null IDENTITY(1,1) Primary key,
FirstName varchar (50) not null,
LastName varchar (50) not null,
Email varchar (50) null,
DOB date not null,
Phone varchar (20) null)

Create Table EmpHours(
EmpHoursID int not null IDENTITY(1,1) Primary key,
WorkDate date not null,
Hours decimal not null,
EmpID int not null Constraint FK_EmpID Foreign Key (EmpID) References Employees on delete cascade,
)

INSERT INTO Employees
VALUES ('John', 'Smith','john.smith@gmail.com','1988/03/01', '9234 5678'),
('James', 'Bond','JamesBond@hotmail.com','1960/08/11', '6975 1235'),
('Jane', 'Doe','Jane_Doe225@gmail.com','1991/09/09', '8564 4578'),
('Marc', 'Jacobs','Marc_J123_@outlook.com','1965/12/01', '9234 7289'),
('Tim', 'Paul','tim-paul@yahoo.com','1978/05/25', '9426 8974'),
('Mary', 'Jane','MaryJane_123_@aol.com','1994/11/01', '9457 6317')

INSERT INTO EmpHours
VALUES ('2018/04/01', 8, 1),
('2018/04/01', 8, 2),
('2018/04/02', 7.5, 3),
('2018/04/04', 6, 4),
('2018/04/25', 8, 5),
('2018/05/11', 7, 6)