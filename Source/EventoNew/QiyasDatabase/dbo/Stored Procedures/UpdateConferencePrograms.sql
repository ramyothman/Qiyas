CREATE PROCEDURE [dbo].[UpdateConferencePrograms]
    @OldConferenceProgramId int,
    @ProgramName nvarchar(50),
    @ConferenceId int
AS
UPDATE [Conference].[ConferencePrograms]
SET
    ProgramName = @ProgramName,
    ConferenceId = @ConferenceId
WHERE [ConferenceProgramId] = @OLDConferenceProgramId
IF @@ROWCOUNT > 0
Select * From Conference.ConferencePrograms 
Where [ConferenceProgramId] = @OLDConferenceProgramId
