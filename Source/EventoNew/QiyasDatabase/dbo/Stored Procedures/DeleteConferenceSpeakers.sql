CREATE PROCEDURE [dbo].[DeleteConferenceSpeakers]
    @ConferenceSpeakerId int

AS
Begin
 Delete [Conference].[ConferenceSpeakers] where     [ConferenceSpeakerId] = @ConferenceSpeakerId
End
