CREATE PROCEDURE [dbo].[DeleteConferencePrograms]
    @ConferenceProgramId int

AS
Begin
 Delete [Conference].[ConferencePrograms] where     [ConferenceProgramId] = @ConferenceProgramId
End
