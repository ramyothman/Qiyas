CREATE PROCEDURE [dbo].[DeletePersonRegisterationStatus]
    @PersonRegisterationStatusId int

AS
Begin
 Delete [PGME].[PersonRegisterationStatus] where     [PersonRegisterationStatusId] = @PersonRegisterationStatusId
End
