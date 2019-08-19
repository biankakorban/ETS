-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	select an employee by EmpID
-- =============================================
CREATE PROCEDURE sp_Employees_SelectAnEmployeeByID

@empID int

AS
BEGIN
	SELECT *
	FROM Employees
	WHERE EmpID = @empID
END
GO

sp_Employees_SelectAnEmployeeByID 5
