CREATE PROCEDURE [dbo].[GetByIDUserMonitor]
    @UserMonitorId int

AS
BEGIN
Select UserMonitorId, PersonId, IsSuccess, UserIP, UserName, DateCreated
From [RoleSecurity].[UserMonitor]

WHERE [UserMonitorId] = @UserMonitorId
END
