CREATE PROCEDURE [dbo].[DeleteConferencesLanguage]
    @ConferenceId int

AS
Begin
 Delete [Conference].[ConferencesLanguage] where     [ConferenceId] = @ConferenceId
End
