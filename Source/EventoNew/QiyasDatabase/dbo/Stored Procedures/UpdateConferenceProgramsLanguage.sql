CREATE PROCEDURE [dbo].[UpdateConferenceProgramsLanguage]
    @OldConferenceProgramId int,
    @ProgramName nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ConferenceProgramParentID int
AS
UPDATE [Conference].[ConferenceProgramsLanguage]
SET
    ProgramName = @ProgramName,
    ConferenceId = @ConferenceId,
    LanguageID = @LanguageID,
    ConferenceProgramParentID = @ConferenceProgramParentID
WHERE [ConferenceProgramId] = @OLDConferenceProgramId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceProgramsLanguage 
Where [ConferenceProgramId] = @OLDConferenceProgramId
