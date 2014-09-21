CREATE PROCEDURE [dbo].[DeleteConferenceRegisterationsLanguage]
    @ConferenceRegistererId int

AS
Begin
 Delete [Conference].[ConferenceRegisterationsLanguage] where     [ConferenceRegistererId] = @ConferenceRegistererId
End
