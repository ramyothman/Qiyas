CREATE PROCEDURE [dbo].[UpdateConferenceHallsLanguage]
    @OldConferenceHallsId int,
    @Name nvarchar(50),
    @ConferenceId int,
    @MapPath nvarchar(500),
    @LanguageID int,
    @ConferenceHallsParentID int
AS
UPDATE [Conference].[ConferenceHallsLanguage]
SET
    Name = @Name,
    ConferenceId = @ConferenceId,
    MapPath = @MapPath,
    LanguageID = @LanguageID,
    ConferenceHallsParentID = @ConferenceHallsParentID
WHERE [ConferenceHallsId] = @OLDConferenceHallsId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceHallsLanguage 
Where [ConferenceHallsId] = @OLDConferenceHallsId
