CREATE PROCEDURE [dbo].[DeleteBusinessEntityContact]
    @PersonId int

AS
Begin
 Delete [Person].[BusinessEntityContact] where     [PersonId] = @PersonId
End
