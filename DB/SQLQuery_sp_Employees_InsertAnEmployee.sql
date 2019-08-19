-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	insert an employee into Employees table
-- =============================================
CREATE PROCEDURE sp_Employees_InsertAnEmployee

	@firstName varchar(50),
	@lastName varchar (50),
	@email varchar (50),
	@dob date,
	@phone varchar (20)

AS
BEGIN

	INSERT INTO Employees 
	(FirstName, LastName, Email, DOB, Phone)
	VALUES (@firstName, @lastName, @email, @dob, @phone)

END
GO

sp_Employees_InsertAnEmployee 'James', 'Dean', 'james.dean@gmail.com', '1978-12-25', '9874 8997'

Select *
From Employees
