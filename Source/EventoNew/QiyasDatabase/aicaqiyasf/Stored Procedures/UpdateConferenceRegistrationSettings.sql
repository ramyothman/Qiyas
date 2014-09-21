CREATE PROCEDURE [aicaqiyasf].UpdateConferenceRegistrationSettings
    @OldConferenceRegistrationSettingID int,
    @ConferenceID int,
    @RegistrationEndDate datetime,
    @RegistrationStartDate datetime,
    @IsActive bit
AS
UPDATE [Conference].[ConferenceRegistrationSettings]
SET
    ConferenceID = @ConferenceID,
    RegistrationEndDate = @RegistrationEndDate,
    RegistrationStartDate = @RegistrationStartDate,
    IsActive = @IsActive
WHERE [ConferenceRegistrationSettingID] = @OLDConferenceRegistrationSettingID
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceRegistrationSettings 
Where [ConferenceRegistrationSettingID] = @OLDConferenceRegistrationSettingID
