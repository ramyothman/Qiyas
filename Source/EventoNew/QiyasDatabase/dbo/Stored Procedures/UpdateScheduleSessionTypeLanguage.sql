CREATE PROCEDURE [dbo].[UpdateScheduleSessionTypeLanguage]
    @OldScheduleSessionTypeId int,
    @Name nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ScheduleSessionTypeParentId int
AS
UPDATE [Conference].[ScheduleSessionTypeLanguage]
SET
    Name = @Name,
    ConferenceId = @ConferenceId,
    LanguageID = @LanguageID,
    ScheduleSessionTypeParentId = @ScheduleSessionTypeParentId
WHERE [ScheduleSessionTypeId] = @OLDScheduleSessionTypeId
IF @@ROWCOUNT > 0
Select * From Conference.ScheduleSessionTypeLanguage 
Where [ScheduleSessionTypeId] = @OLDScheduleSessionTypeId
