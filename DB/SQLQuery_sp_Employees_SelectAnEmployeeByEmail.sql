-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	select an employee by Email
-- =============================================
CREATE PROCEDURE sp_Employees_SelectAnEmployeeByEmail

@email varchar (50)

AS
BEGIN
	SELECT *
	FROM Employees
	WHERE Email  = @email
END
GO

sp_Employees_SelectAnEmployeeByEmail 'john.smith@gmail.com'
