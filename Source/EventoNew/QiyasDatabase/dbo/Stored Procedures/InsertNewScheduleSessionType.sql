CREATE PROCEDURE [dbo].[InsertNewScheduleSessionType]
    @ScheduleSessionTypeId int output ,
    @Name nvarchar(50),
    @ConferenceId int
AS
INSERT INTO [Conference].[ScheduleSessionType] (
    [Name],
    [ConferenceId])
Values (
    @Name,
    @ConferenceId)
Set @ScheduleSessionTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ScheduleSessionType
Where [ScheduleSessionTypeId] = @@identity
