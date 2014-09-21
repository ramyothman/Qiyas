CREATE PROCEDURE [dbo].[InsertNewConferencePrograms]
    @ConferenceProgramId int output ,
    @ProgramName nvarchar(50),
    @ConferenceId int
AS
INSERT INTO [Conference].[ConferencePrograms] (
    [ProgramName],
    [ConferenceId])
Values (
    @ProgramName,
    @ConferenceId)
Set @ConferenceProgramId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferencePrograms
Where [ConferenceProgramId] = @@identity
