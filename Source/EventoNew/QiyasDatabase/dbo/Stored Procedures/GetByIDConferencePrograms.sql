CREATE PROCEDURE [dbo].[GetByIDConferencePrograms]
    @ConferenceProgramId int

AS
BEGIN
Select ConferenceProgramId, ProgramName, ConferenceId
From [Conference].[ConferencePrograms]

WHERE [ConferenceProgramId] = @ConferenceProgramId
END
