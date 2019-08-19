-- =============================================
-- Author:		Bianka	
-- Create date: 27/05/2018
-- Description:	select emoployee work date and hours by EmpID
-- =============================================
CREATE PROCEDURE sp_EmpHours_SelectEmployeeWorkDateHoursByEmpID
	
	@empID int

AS
BEGIN
	SELECT EmpID, WorkDate, Hours
	FROM EmpHours
	WHERE EmpID = @empID
END
GO


sp_EmpHours_SelectEmployeeWorkDateHoursByEmpID 5