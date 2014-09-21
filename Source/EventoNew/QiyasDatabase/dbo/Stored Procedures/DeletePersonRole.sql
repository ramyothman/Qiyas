CREATE PROCEDURE [dbo].[DeletePersonRole]
    @PersonRoleId int

AS
Begin
 Delete [RoleSecurity].[PersonRole] where     [PersonRoleId] = @PersonRoleId
End
