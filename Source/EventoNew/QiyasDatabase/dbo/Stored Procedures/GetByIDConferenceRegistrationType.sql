CREATE PROCEDURE GetByIDConferenceRegistrationType
    @ConferenceRegistrationTypeId int

AS
BEGIN
Select ConferenceRegistrationTypeId, ConferenceId, Name, Fee, GroupName, StartDate, EndDate, EarlyRegistrationEndDate, LateFee, ConferenceScheduleID, OfferStartDate, OfferEndDate, OfferFee, HaveOffer, MustRegister
From [Conference].[ConferenceRegistrationType]

WHERE [ConferenceRegistrationTypeId] = @ConferenceRegistrationTypeId
END
