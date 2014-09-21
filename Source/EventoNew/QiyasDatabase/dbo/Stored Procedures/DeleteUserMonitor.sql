CREATE PROCEDURE [dbo].[DeleteUserMonitor]
    @UserMonitorId int

AS
Begin
 Delete [RoleSecurity].[UserMonitor] where     [UserMonitorId] = @UserMonitorId
End
