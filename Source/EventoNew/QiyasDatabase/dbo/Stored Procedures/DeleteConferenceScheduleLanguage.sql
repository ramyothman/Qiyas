CREATE PROCEDURE [dbo].[DeleteConferenceScheduleLanguage]
    @ScheduleId int

AS
Begin
 Delete [Conference].[ConferenceScheduleLanguage] where     [ScheduleId] = @ScheduleId
End
