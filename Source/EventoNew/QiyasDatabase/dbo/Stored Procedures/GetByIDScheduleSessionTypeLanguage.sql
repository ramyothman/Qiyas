CREATE PROCEDURE [dbo].[GetByIDScheduleSessionTypeLanguage]
    @ScheduleSessionTypeId int

AS
BEGIN
Select ScheduleSessionTypeId, Name, ConferenceId, LanguageID, ScheduleSessionTypeParentId
From [Conference].[ScheduleSessionTypeLanguage]

WHERE [ScheduleSessionTypeId] = @ScheduleSessionTypeId
END
