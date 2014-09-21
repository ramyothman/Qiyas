CREATE PROCEDURE [aicaqiyasf].InsertNewConferenceRegistrationSettings
    @ConferenceRegistrationSettingID int output ,
    @ConferenceID int,
    @RegistrationEndDate datetime,
    @RegistrationStartDate datetime,
    @IsActive bit
AS
INSERT INTO [Conference].[ConferenceRegistrationSettings] (
    [ConferenceID],
    [RegistrationEndDate],
    [RegistrationStartDate],
    [IsActive])
Values (
    @ConferenceID,
    @RegistrationEndDate,
    @RegistrationStartDate,
    @IsActive)
Set @ConferenceRegistrationSettingID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegistrationSettings
Where [ConferenceRegistrationSettingID] = @@identity
