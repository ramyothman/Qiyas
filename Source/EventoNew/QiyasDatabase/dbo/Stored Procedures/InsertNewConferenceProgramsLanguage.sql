CREATE PROCEDURE [dbo].[InsertNewConferenceProgramsLanguage]
    @ConferenceProgramId int output ,
    @ProgramName nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ConferenceProgramParentID int
AS
INSERT INTO [Conference].[ConferenceProgramsLanguage] (
    [ProgramName],
    [ConferenceId],
    [LanguageID],
    [ConferenceProgramParentID])
Values (
    @ProgramName,
    @ConferenceId,
    @LanguageID,
    @ConferenceProgramParentID)
Set @ConferenceProgramId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceProgramsLanguage
Where [ConferenceProgramId] = @@identity
