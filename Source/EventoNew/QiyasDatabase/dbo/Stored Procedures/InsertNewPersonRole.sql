CREATE PROCEDURE [dbo].[InsertNewPersonRole]
    @PersonRoleId int output ,
    @RoleId int,
    @PersonId int,
    @ModifiedDate datetime
AS
INSERT INTO [RoleSecurity].[PersonRole] (
    [RoleId],
    [PersonId],
    [ModifiedDate])
Values (
    @RoleId,
    @PersonId,
    @ModifiedDate)
Set @PersonRoleId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.PersonRole
Where [PersonRoleId] = @@identity
