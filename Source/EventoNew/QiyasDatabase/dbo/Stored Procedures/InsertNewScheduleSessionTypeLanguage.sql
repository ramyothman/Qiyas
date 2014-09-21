CREATE PROCEDURE [dbo].[InsertNewScheduleSessionTypeLanguage]
    @ScheduleSessionTypeId int output ,
    @Name nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ScheduleSessionTypeParentId int
AS
INSERT INTO [Conference].[ScheduleSessionTypeLanguage] (
    [Name],
    [ConferenceId],
    [LanguageID],
    [ScheduleSessionTypeParentId])
Values (
    @Name,
    @ConferenceId,
    @LanguageID,
    @ScheduleSessionTypeParentId)
Set @ScheduleSessionTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ScheduleSessionTypeLanguage
Where [ScheduleSessionTypeId] = @@identity
