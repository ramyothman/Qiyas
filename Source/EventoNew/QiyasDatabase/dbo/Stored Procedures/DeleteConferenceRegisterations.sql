CREATE PROCEDURE [dbo].[DeleteConferenceRegisterations]
    @ConferenceRegistererId int

AS
Begin
 Delete [Conference].[ConferenceRegisterations] where     [ConferenceRegistererId] = @ConferenceRegistererId
End
