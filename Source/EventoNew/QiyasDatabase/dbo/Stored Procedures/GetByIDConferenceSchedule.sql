CREATE PROCEDURE [dbo].[GetByIDConferenceSchedule]
    @ScheduleId int

AS
BEGIN
Select ScheduleId, ConferenceProgramId, Title, ScheduleSessionTypeId, StartTime, EndTime, SpeakerName, ConferenceHallId, Description, AllDescription, SpeakerID, DocPath
From [Conference].[ConferenceSchedule]

WHERE [ScheduleId] = @ScheduleId
END
