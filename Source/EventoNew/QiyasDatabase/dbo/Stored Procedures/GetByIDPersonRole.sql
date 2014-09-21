CREATE PROCEDURE [dbo].[GetByIDPersonRole]
    @PersonRoleId int

AS
BEGIN
Select PersonRoleId, RoleId, PersonId, ModifiedDate
From [RoleSecurity].[PersonRole]

WHERE [PersonRoleId] = @PersonRoleId
END
