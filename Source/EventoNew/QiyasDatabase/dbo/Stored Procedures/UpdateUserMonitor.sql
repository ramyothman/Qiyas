CREATE PROCEDURE [dbo].[UpdateUserMonitor]
    @OldUserMonitorId int,
    @PersonId int,
    @IsSuccess bit,
    @UserIP nvarchar(50),
    @UserName nvarchar(50),
    @DateCreated datetime
AS
UPDATE [RoleSecurity].[UserMonitor]
SET
    PersonId = @PersonId,
    IsSuccess = @IsSuccess,
    UserIP = @UserIP,
    UserName = @UserName,
    DateCreated = @DateCreated
WHERE [UserMonitorId] = @OLDUserMonitorId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.UserMonitor 
Where [UserMonitorId] = @OLDUserMonitorId
