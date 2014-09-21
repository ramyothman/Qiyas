CREATE PROCEDURE [dbo].[DeleteRolePrivilege]
    @RolePrivilegeId int

AS
Begin
 Delete [RoleSecurity].[RolePrivilege] where     [RolePrivilegeId] = @RolePrivilegeId
End
