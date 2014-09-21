CREATE PROCEDURE [dbo].[InsertNewSecurityAccessType]
    @SecurityAccessTypeId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [RoleSecurity].[SecurityAccessType] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @SecurityAccessTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.SecurityAccessType
Where [SecurityAccessTypeId] = @@identity
