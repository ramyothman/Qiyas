CREATE PROCEDURE [dbo].[DeleteInvitedGuests]
    @ID int

AS
Begin
 Delete [Conference].[InvitedGuests] where     [ID] = @ID
End
