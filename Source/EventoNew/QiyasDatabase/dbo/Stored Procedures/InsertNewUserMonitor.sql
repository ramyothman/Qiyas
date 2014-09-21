CREATE PROCEDURE [dbo].[InsertNewUserMonitor]
    @UserMonitorId int output ,
    @PersonId int,
    @IsSuccess bit,
    @UserIP nvarchar(50),
    @UserName nvarchar(50),
    @DateCreated datetime
AS
INSERT INTO [RoleSecurity].[UserMonitor] (
    [PersonId],
    [IsSuccess],
    [UserIP],
    [UserName],
    [DateCreated])
Values (
    @PersonId,
    @IsSuccess,
    @UserIP,
    @UserName,
    @DateCreated)
Set @UserMonitorId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.UserMonitor
Where [UserMonitorId] = @@identity
