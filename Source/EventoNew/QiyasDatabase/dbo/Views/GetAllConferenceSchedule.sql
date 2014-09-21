CREATE VIEW dbo.GetAllConferenceSchedule
AS
SELECT        Conference.ConferenceSchedule.ScheduleId, Conference.ConferenceSchedule.ConferenceProgramId, Conference.ConferenceSchedule.Title, 
                         Conference.ConferenceSchedule.ScheduleSessionTypeId, Conference.ConferenceSchedule.StartTime, Conference.ConferenceSchedule.EndTime, 
                         Conference.ConferenceSchedule.SpeakerName, Conference.ConferenceSchedule.ConferenceHallId, Conference.ConferenceSchedule.Description, 
                         Conference.ConferenceSchedule.AllDescription, Conference.ConferenceSchedule.SpeakerID, Conference.ConferenceSchedule.DocPath, 
                         Conference.ConferencePrograms.ConferenceId
FROM            Conference.ConferenceSchedule INNER JOIN
                         Conference.ConferencePrograms ON Conference.ConferenceSchedule.ConferenceProgramId = Conference.ConferencePrograms.ConferenceProgramId
