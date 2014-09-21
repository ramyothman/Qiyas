CREATE PROCEDURE [dbo].[UpdateConferenceHalls]
    @OldConferenceHallsId int,
    @Name nvarchar(50),
    @ConferenceId int,
    @MapPath nvarchar(500)
AS
UPDATE [Conference].[ConferenceHalls]
SET
    Name = @Name,
    ConferenceId = @ConferenceId,
    MapPath = @MapPath
WHERE [ConferenceHallsId] = @OLDConferenceHallsId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceHalls 
Where [ConferenceHallsId] = @OLDConferenceHallsId
