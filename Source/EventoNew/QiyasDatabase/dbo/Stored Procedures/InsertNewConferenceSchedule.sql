CREATE PROCEDURE [dbo].[InsertNewConferenceSchedule]
    @ScheduleId int output ,
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
    @DocPath nvarchar(50)
AS
INSERT INTO [Conference].[ConferenceSchedule] (
    [ConferenceProgramId],
    [Title],
    
    [ScheduleSessionTypeId],
    [StartTime],
    [EndTime],
    [SpeakerName],
    [ConferenceHallId],
    [Description],
    [AllDescription],
    [SpeakerID],
    [DocPath])
Values (
    @ConferenceProgramId,
    @Title,
  
    @ScheduleSessionTypeId,
    @StartTime,
    @EndTime,
    @SpeakerName,
    @ConferenceHallId,
    @Description,
    @AllDescription,
    @SpeakerID,
    @DocPath)
Set @ScheduleId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceSchedule
Where [ScheduleId] = @@identity
