CREATE PROCEDURE [dbo].[DeleteSystemFunction]
    @SystemFunctionId int

AS
Begin
 Delete [RoleSecurity].[SystemFunction] where     [SystemFunctionId] = @SystemFunctionId
End
