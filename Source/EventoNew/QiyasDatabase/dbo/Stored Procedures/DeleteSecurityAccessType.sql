CREATE PROCEDURE [dbo].[DeleteSecurityAccessType]
    @SecurityAccessTypeId int

AS
Begin
 Delete [RoleSecurity].[SecurityAccessType] where     [SecurityAccessTypeId] = @SecurityAccessTypeId
End
