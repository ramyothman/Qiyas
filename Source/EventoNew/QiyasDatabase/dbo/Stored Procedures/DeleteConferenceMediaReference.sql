CREATE PROCEDURE [dbo].[DeleteConferenceMediaReference]
    @ConferenceMediaReferenceId int

AS
Begin
 Delete [Conference].[ConferenceMediaReference] where     [ConferenceMediaReferenceId] = @ConferenceMediaReferenceId
End
