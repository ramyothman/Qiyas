CREATE PROCEDURE [dbo].[DeleteRole]
    @RoleId int

AS
Begin
 Delete [RoleSecurity].[Role] where     [RoleId] = @RoleId
End
