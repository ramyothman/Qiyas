CREATE PROCEDURE [aicaqiyasf].GetByIDConferenceRegistrationItems
    @ConferenceRegistrationItemID int

AS
BEGIN
Select ConferenceRegistrationItemID, ConferenceRegistrationTypeID, ConferenceRegistererId, CreatedDate
From [Conference].[ConferenceRegistrationItems]

WHERE [ConferenceRegistrationItemID] = @ConferenceRegistrationItemID
END
