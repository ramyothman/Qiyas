CREATE PROCEDURE [dbo].[DeleteConferenceSchedule]
    @ScheduleId int

AS
Begin
 Delete [Conference].[ConferenceSchedule] where     [ScheduleId] = @ScheduleId
End
