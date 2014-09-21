CREATE PROCEDURE [dbo].[GetByIDRolePrivilege]
    @RolePrivilegeId int

AS
BEGIN
Select RolePrivilegeId, RoleId, ContentEntityId, SystemFunctionId, HasAccess, ModifiedDate
From [RoleSecurity].[RolePrivilege]

WHERE [RolePrivilegeId] = @RolePrivilegeId
END
