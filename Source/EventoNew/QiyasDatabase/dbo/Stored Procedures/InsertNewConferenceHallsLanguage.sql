CREATE PROCEDURE [dbo].[InsertNewConferenceHallsLanguage]
    @ConferenceHallsId int output ,
    @Name nvarchar(50),
    @ConferenceId int,
    @MapPath nvarchar(500),
    @LanguageID int,
    @ConferenceHallsParentID int
AS
INSERT INTO [Conference].[ConferenceHallsLanguage] (
    [Name],
    [ConferenceId],
    [MapPath],
    [LanguageID],
    [ConferenceHallsParentID])
Values (
    @Name,
    @ConferenceId,
    @MapPath,
    @LanguageID,
    @ConferenceHallsParentID)
Set @ConferenceHallsId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceHallsLanguage
Where [ConferenceHallsId] = @@identity
