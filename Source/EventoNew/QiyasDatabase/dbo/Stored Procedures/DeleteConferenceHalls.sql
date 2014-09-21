CREATE PROCEDURE [dbo].[DeleteConferenceHalls]
    @ConferenceHallsId int

AS
Begin
 Delete [Conference].[ConferenceHalls] where     [ConferenceHallsId] = @ConferenceHallsId
End
