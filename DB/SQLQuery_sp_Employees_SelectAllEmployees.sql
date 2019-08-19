-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	select all employees
-- =============================================
CREATE PROCEDURE sp_Employees_SelectAllEmployees


AS
BEGIN
	SELECT *
	FROM Employees
END
GO


sp_Employees_SelectAllEmployees