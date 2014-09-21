CREATE PROCEDURE [dbo].[DeleteScheduleSessionTypeLanguage]
    @ScheduleSessionTypeId int

AS
Begin
 Delete [Conference].[ScheduleSessionTypeLanguage] where     [ScheduleSessionTypeId] = @ScheduleSessionTypeId
End
