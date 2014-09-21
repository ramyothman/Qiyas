CREATE PROCEDURE [dbo].[DeletePersonPGMERegisteration]
    @PersonRegisterationId int

AS
Begin
 Delete [PGME].[PersonPGMERegisteration] where     [PersonRegisterationId] = @PersonRegisterationId
End
