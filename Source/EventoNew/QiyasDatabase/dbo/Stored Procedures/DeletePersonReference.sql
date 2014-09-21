CREATE PROCEDURE [dbo].[DeletePersonReference]
    @PersonReferenceId int

AS
Begin
 Delete [PGME].[PersonReference] where     [PersonReferenceId] = @PersonReferenceId
End
