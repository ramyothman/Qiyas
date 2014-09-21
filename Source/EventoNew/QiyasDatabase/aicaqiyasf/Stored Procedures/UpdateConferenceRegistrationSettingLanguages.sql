CREATE PROCEDURE [aicaqiyasf].UpdateConferenceRegistrationSettingLanguages
    @OldConferenceRegistrationSettingLanguageID int,
    @ConferenceRegistrationSettingID int,
    @RegistrationShorInstructions nvarchar(500),
    @RegistrationInstructionsInFormPre ntext,
    @RegistrationInstructionsInFormPost nchar(10),
    @PostRegistrationInstructions ntext,
    @LanguageID int
AS
UPDATE [Conference].[ConferenceRegistrationSettingLanguages]
SET
    ConferenceRegistrationSettingID = @ConferenceRegistrationSettingID,
    RegistrationShorInstructions = @RegistrationShorInstructions,
    RegistrationInstructionsInFormPre = @RegistrationInstructionsInFormPre,
    RegistrationInstructionsInFormPost = @RegistrationInstructionsInFormPost,
    PostRegistrationInstructions = @PostRegistrationInstructions,
    LanguageID = @LanguageID
WHERE [ConferenceRegistrationSettingLanguageID] = @OLDConferenceRegistrationSettingLanguageID
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceRegistrationSettingLanguages 
Where [ConferenceRegistrationSettingLanguageID] = @OLDConferenceRegistrationSettingLanguageID
