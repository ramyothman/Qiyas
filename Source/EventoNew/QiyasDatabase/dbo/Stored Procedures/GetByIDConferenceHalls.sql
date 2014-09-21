CREATE PROCEDURE [dbo].[GetByIDConferenceHalls]
    @ConferenceHallsId int

AS
BEGIN
Select ConferenceHallsId, Name, ConferenceId, MapPath
From [Conference].[ConferenceHalls]

WHERE [ConferenceHallsId] = @ConferenceHallsId
END
