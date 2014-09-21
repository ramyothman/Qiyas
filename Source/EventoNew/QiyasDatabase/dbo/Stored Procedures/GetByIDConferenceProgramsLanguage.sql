CREATE PROCEDURE [dbo].[GetByIDConferenceProgramsLanguage]
    @ConferenceProgramId int

AS
BEGIN
Select ConferenceProgramId, ProgramName, ConferenceId, LanguageID, ConferenceProgramParentID
From [Conference].[ConferenceProgramsLanguage]

WHERE [ConferenceProgramId] = @ConferenceProgramId
END
