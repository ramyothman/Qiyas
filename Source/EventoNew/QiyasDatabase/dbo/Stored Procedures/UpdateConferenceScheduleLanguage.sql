CREATE PROCEDURE [dbo].[UpdateConferenceScheduleLanguage]
    @OldScheduleId int,
    @ConferenceProgramId int,
    @Title nvarchar(500),
    @ScheduleSessionTypeId int,
    @StartTime datetime,
    @EndTime datetime,
    @SpeakerName nvarchar(50),
    @ConferenceHallId int,
    @Description nvarchar(250),
    @AllDescription ntext,
    @SpeakerID int,
    @DocPath nvarchar(50),
    @ScheduleparentID int,
    @LanguageID int
AS
UPDATE [Conference].[ConferenceScheduleLanguage]
SET
    ConferenceProgramId = @ConferenceProgramId,
    Title = @Title,
    ScheduleSessionTypeId = @ScheduleSessionTypeId,
    StartTime = @StartTime,
    EndTime = @EndTime,
    SpeakerName = @SpeakerName,
    ConferenceHallId = @ConferenceHallId,
    Description = @Description,
    AllDescription = @AllDescription,
    SpeakerID = @SpeakerID,
    DocPath = @DocPath,
    ScheduleparentID = @ScheduleparentID,
    LanguageID = @LanguageID
WHERE [ScheduleId] = @OLDScheduleId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceScheduleLanguage 
Where [ScheduleId] = @OLDScheduleId
