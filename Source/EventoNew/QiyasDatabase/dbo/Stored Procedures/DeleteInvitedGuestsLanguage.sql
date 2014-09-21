CREATE PROCEDURE [dbo].[DeleteInvitedGuestsLanguage]
    @ID int

AS
Begin
 Delete [Conference].[InvitedGuestsLanguage] where     [ID] = @ID
End
