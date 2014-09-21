CREATE PROCEDURE [aicaqiyasf].UpdateConferenceRegistrationItems
    @OldConferenceRegistrationItemID int,
    @ConferenceRegistrationTypeID int,
    @ConferenceRegistererId int,
    @CreatedDate datetime
AS
UPDATE [Conference].[ConferenceRegistrationItems]
SET
    ConferenceRegistrationTypeID = @ConferenceRegistrationTypeID,
    ConferenceRegistererId = @ConferenceRegistererId,
    CreatedDate = @CreatedDate
WHERE [ConferenceRegistrationItemID] = @OLDConferenceRegistrationItemID
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceRegistrationItems 
Where [ConferenceRegistrationItemID] = @OLDConferenceRegistrationItemID
