CREATE PROCEDURE [dbo].[DeleteConferenceHallsLanguage]
    @ConferenceHallsId int

AS
Begin
 Delete [Conference].[ConferenceHallsLanguage] where     [ConferenceHallsId] = @ConferenceHallsId
End
