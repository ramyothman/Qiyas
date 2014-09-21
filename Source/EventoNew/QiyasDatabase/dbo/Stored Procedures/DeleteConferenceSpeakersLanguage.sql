CREATE PROCEDURE [dbo].[DeleteConferenceSpeakersLanguage]
    @ConferenceSpeakerId int

AS
Begin
 Delete [Conference].[ConferenceSpeakersLanguage] where     [ConferenceSpeakerId] = @ConferenceSpeakerId
End
