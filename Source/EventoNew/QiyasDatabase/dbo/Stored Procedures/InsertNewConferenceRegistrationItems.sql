CREATE PROCEDURE InsertNewConferenceRegistrationItems
    @ConferenceRegistrationItemID int output ,
    @ConferenceRegistrationTypeID int,
    @ConferenceRegistererId int,
    @CreatedDate datetime
AS
INSERT INTO [Conference].[ConferenceRegistrationItems] (
    [ConferenceRegistrationTypeID],
    [ConferenceRegistererId],
    [CreatedDate])
Values (
    @ConferenceRegistrationTypeID,
    @ConferenceRegistererId,
    @CreatedDate)
Set @ConferenceRegistrationItemID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegistrationItems
Where [ConferenceRegistrationItemID] = @@identity
