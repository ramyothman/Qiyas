CREATE PROCEDURE [aicaqiyasf].DeleteConferenceRegistrationSettings
    @ConferenceRegistrationSettingID int

AS
Begin
 Delete [Conference].[ConferenceRegistrationSettings] where     [ConferenceRegistrationSettingID] = @ConferenceRegistrationSettingID
End
