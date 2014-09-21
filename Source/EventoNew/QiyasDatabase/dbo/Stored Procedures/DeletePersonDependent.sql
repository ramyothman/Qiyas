CREATE PROCEDURE [dbo].[DeletePersonDependent]
    @PersonDependentId int

AS
Begin
 Delete [Person].[PersonDependent] where     [PersonDependentId] = @PersonDependentId
End
