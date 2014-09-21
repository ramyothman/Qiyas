CREATE PROCEDURE [dbo].[GetByIDScheduleSessionType]
    @ScheduleSessionTypeId int

AS
BEGIN
Select ScheduleSessionTypeId, Name, ConferenceId
From [Conference].[ScheduleSessionType]

WHERE [ScheduleSessionTypeId] = @ScheduleSessionTypeId
END
