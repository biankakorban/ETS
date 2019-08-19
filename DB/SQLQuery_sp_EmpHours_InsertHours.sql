-- =============================================
-- Author:		Bianka
-- Create date: 27/05/2018
-- Description:	insert the employee's hours into EmpHours table
-- =============================================
CREATE PROCEDURE sp_EmpHours_InsertHours
     
	 @workDate date,
	 @hours decimal,
	 @empID int
	
AS
BEGIN
	INSERT INTO EmpHours (WorkDate, Hours, EmpID)
	VALUES (@workDate, @hours, @empID)
END
GO

sp_EmpHours_InsertHours '2018-05-26', 8, 7

Select *
From EmpHours

