CREATE PROCEDURE [dbo].[InsertNewConferenceScheduleLanguage]
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
    @DocPath nvarchar(50),
    @ScheduleparentID int,
    @LanguageID int
AS
INSERT INTO [Conference].[ConferenceScheduleLanguage] (
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
    [DocPath],
    [ScheduleparentID],
    [LanguageID])
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
    @DocPath,
    @ScheduleparentID,
    @LanguageID)
Set @ScheduleId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceScheduleLanguage
Where [ScheduleId] = @@identity
