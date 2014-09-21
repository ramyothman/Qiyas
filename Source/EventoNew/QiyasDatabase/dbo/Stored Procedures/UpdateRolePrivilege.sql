CREATE PROCEDURE [dbo].[UpdateRolePrivilege]
    @OldRolePrivilegeId int,
    @RoleId int,
    @ContentEntityId int,
    @SystemFunctionId int,
    @HasAccess bit,
    @ModifiedDate datetime
AS
UPDATE [RoleSecurity].[RolePrivilege]
SET
    RoleId = @RoleId,
    ContentEntityId = @ContentEntityId,
    SystemFunctionId = @SystemFunctionId,
    HasAccess = @HasAccess,
    ModifiedDate = @ModifiedDate
WHERE [RolePrivilegeId] = @OLDRolePrivilegeId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.RolePrivilege 
Where [RolePrivilegeId] = @OLDRolePrivilegeId
