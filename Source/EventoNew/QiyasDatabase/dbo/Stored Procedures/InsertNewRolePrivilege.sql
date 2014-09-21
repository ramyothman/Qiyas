CREATE PROCEDURE [dbo].[InsertNewRolePrivilege]
    @RolePrivilegeId int output ,
    @RoleId int,
    @ContentEntityId int,
    @SystemFunctionId int,
    @HasAccess bit,
    @ModifiedDate datetime
AS
INSERT INTO [RoleSecurity].[RolePrivilege] (
    [RoleId],
    [ContentEntityId],
    [SystemFunctionId],
    [HasAccess],
    [ModifiedDate])
Values (
    @RoleId,
    @ContentEntityId,
    @SystemFunctionId,
    @HasAccess,
    @ModifiedDate)
Set @RolePrivilegeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.RolePrivilege
Where [RolePrivilegeId] = @@identity
