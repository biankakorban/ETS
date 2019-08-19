-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	update an employee from Employees table
-- =============================================
CREATE PROCEDURE sp_Employees_UpdateAnEmployee

	@empID int,
	@firstName varchar(50),
	@lastName varchar (50),
	@email varchar (50),
	@dob date,
	@phone varchar (20)


AS
BEGIN

	UPDATE Employees 
	SET FirstName = @firstName, LastName = @lastName, Email = @email, DOB = @dob, Phone = @phone
	Where EmpID = @empID

END
GO

sp_Employees_UpdateAnEmployee 7, 'James', 'Dean', 'james.dean@gmail.com', '1978-12-15', '9874 8997'

Select *
From Employees

