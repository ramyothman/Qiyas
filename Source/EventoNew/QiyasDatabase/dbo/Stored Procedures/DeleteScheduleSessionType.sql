CREATE PROCEDURE [dbo].[DeleteScheduleSessionType]
    @ScheduleSessionTypeId int

AS
Begin
 Delete [Conference].[ScheduleSessionType] where     [ScheduleSessionTypeId] = @ScheduleSessionTypeId
End
