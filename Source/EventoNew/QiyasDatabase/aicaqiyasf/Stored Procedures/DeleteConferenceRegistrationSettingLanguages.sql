CREATE PROCEDURE [aicaqiyasf].DeleteConferenceRegistrationSettingLanguages
    @ConferenceRegistrationSettingLanguageID int

AS
Begin
 Delete [Conference].[ConferenceRegistrationSettingLanguages] where     [ConferenceRegistrationSettingLanguageID] = @ConferenceRegistrationSettingLanguageID
End
