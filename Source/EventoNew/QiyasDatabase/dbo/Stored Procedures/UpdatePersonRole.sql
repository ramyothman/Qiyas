CREATE PROCEDURE [dbo].[UpdatePersonRole]
    @OldPersonRoleId int,
    @RoleId int,
    @PersonId int,
    @ModifiedDate datetime
AS
UPDATE [RoleSecurity].[PersonRole]
SET
    RoleId = @RoleId,
    PersonId = @PersonId,
    ModifiedDate = @ModifiedDate
WHERE [PersonRoleId] = @OLDPersonRoleId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.PersonRole 
Where [PersonRoleId] = @OLDPersonRoleId
