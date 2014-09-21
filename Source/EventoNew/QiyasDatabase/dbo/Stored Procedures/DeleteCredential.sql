CREATE PROCEDURE [dbo].[DeleteCredential]
    @BusinessEntityId int

AS
Begin
 Delete [Person].[Credential] where     [BusinessEntityId] = @BusinessEntityId
End
