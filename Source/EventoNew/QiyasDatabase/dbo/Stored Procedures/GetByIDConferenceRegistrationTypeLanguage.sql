CREATE PROCEDURE GetByIDConferenceRegistrationTypeLanguage
    @ConferenceRegistrationTypeId int

AS
BEGIN
Select ConferenceRegistrationTypeId, ConferenceId, Name, Fee, ConferenceRegistrationTypeParentId, LanguageID, Description, OfferMessage
From [Conference].[ConferenceRegistrationTypeLanguage]

WHERE [ConferenceRegistrationTypeId] = @ConferenceRegistrationTypeId
END
