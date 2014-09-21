CREATE PROCEDURE [dbo].[InsertNewRole]
    @RoleId int output ,
    @Name nvarchar(50),
    @IsActive bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [RoleSecurity].[Role] (
    [Name],
    [IsActive],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @IsActive,
    @RowGuid,
    @ModifiedDate)
Set @RoleId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.Role
Where [RoleId] = @@identity
