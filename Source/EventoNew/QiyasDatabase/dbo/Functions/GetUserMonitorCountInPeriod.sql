-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[GetUserMonitorCountInPeriod]
(
	-- Add the parameters for the function here
	@UserName nvarchar(50),
	@UserIP nvarchar(50),
	@StartDate datetime,
	@EndDate datetime
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = Count(UserMonitorID) from [RoleSecurity].[UserMonitor]  where
	UserName = @UserName and UserIP = @UserIP and IsSuccess = 0 and DateCreated Between @StartDate and @EndDate 

	if(@Result is null)
	 Set @Result = 0
	-- Return the result of the function
	RETURN @Result

END
