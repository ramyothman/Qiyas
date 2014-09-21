CREATE PROCEDURE [aicaqiyasf].InsertNewConferenceRegistrationSettingLanguages
    @ConferenceRegistrationSettingLanguageID int output ,
    @ConferenceRegistrationSettingID int,
    @RegistrationShorInstructions nvarchar(500),
    @RegistrationInstructionsInFormPre ntext,
    @RegistrationInstructionsInFormPost nchar(10),
    @PostRegistrationInstructions ntext,
    @LanguageID int
AS
INSERT INTO [Conference].[ConferenceRegistrationSettingLanguages] (
    [ConferenceRegistrationSettingID],
    [RegistrationShorInstructions],
    [RegistrationInstructionsInFormPre],
    [RegistrationInstructionsInFormPost],
    [PostRegistrationInstructions],
    [LanguageID])
Values (
    @ConferenceRegistrationSettingID,
    @RegistrationShorInstructions,
    @RegistrationInstructionsInFormPre,
    @RegistrationInstructionsInFormPost,
    @PostRegistrationInstructions,
    @LanguageID)
Set @ConferenceRegistrationSettingLanguageID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegistrationSettingLanguages
Where [ConferenceRegistrationSettingLanguageID] = @@identity
