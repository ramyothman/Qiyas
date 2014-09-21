CREATE PROCEDURE [dbo].[GetByIDConferenceScheduleLanguage]
    @ScheduleId int

AS
BEGIN
Select ScheduleId, ConferenceProgramId, Title, ScheduleSessionTypeId, StartTime, EndTime, SpeakerName, ConferenceHallId, Description, AllDescription, SpeakerID, DocPath, ScheduleparentID, LanguageID
From [Conference].[ConferenceScheduleLanguage]

WHERE [ScheduleId] = @ScheduleId
END
