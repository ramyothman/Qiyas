CREATE PROCEDURE [dbo].[GetByIDConferenceHallsLanguage]
    @ConferenceHallsId int

AS
BEGIN
Select ConferenceHallsId, Name, ConferenceId, MapPath, LanguageID, ConferenceHallsParentID
From [Conference].[ConferenceHallsLanguage]

WHERE [ConferenceHallsId] = @ConferenceHallsId
END
