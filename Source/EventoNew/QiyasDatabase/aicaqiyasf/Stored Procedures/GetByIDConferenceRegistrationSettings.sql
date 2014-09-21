CREATE PROCEDURE [aicaqiyasf].GetByIDConferenceRegistrationSettings
    @ConferenceRegistrationSettingID int

AS
BEGIN
Select ConferenceRegistrationSettingID, ConferenceID, RegistrationEndDate, RegistrationStartDate, IsActive
From [Conference].[ConferenceRegistrationSettings]

WHERE [ConferenceRegistrationSettingID] = @ConferenceRegistrationSettingID
END
