CREATE PROCEDURE [dbo].[UpdateScheduleSessionType]
    @OldScheduleSessionTypeId int,
    @Name nvarchar(50),
    @ConferenceId int
AS
UPDATE [Conference].[ScheduleSessionType]
SET
    Name = @Name,
    ConferenceId = @ConferenceId
WHERE [ScheduleSessionTypeId] = @OLDScheduleSessionTypeId
IF @@ROWCOUNT > 0
Select * From Conference.ScheduleSessionType 
Where [ScheduleSessionTypeId] = @OLDScheduleSessionTypeId
