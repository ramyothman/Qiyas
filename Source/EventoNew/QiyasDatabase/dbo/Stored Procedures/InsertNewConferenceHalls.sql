CREATE PROCEDURE [dbo].[InsertNewConferenceHalls]
    @ConferenceHallsId int output ,
    @Name nvarchar(50),
    @ConferenceId int,
    @MapPath nvarchar(500)
AS
INSERT INTO [Conference].[ConferenceHalls] (
    [Name],
    [ConferenceId],
    [MapPath])
Values (
    @Name,
    @ConferenceId,
    @MapPath)
Set @ConferenceHallsId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceHalls
Where [ConferenceHallsId] = @@identity
