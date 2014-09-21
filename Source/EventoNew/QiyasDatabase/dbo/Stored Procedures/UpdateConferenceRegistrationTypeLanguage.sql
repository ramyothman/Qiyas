CREATE PROCEDURE UpdateConferenceRegistrationTypeLanguage
    @OldConferenceRegistrationTypeId int,
    @ConferenceId int,
    @Name nvarchar(50),
    @Fee decimal(18,2),
    @ConferenceRegistrationTypeParentId int,
    @LanguageID int,
    @Description nvarchar(500),
    @OfferMessage ntext
AS
UPDATE [Conference].[ConferenceRegistrationTypeLanguage]
SET
    ConferenceId = @ConferenceId,
    Name = @Name,
    Fee = @Fee,
    ConferenceRegistrationTypeParentId = @ConferenceRegistrationTypeParentId,
    LanguageID = @LanguageID,
    Description = @Description,
    OfferMessage = @OfferMessage
WHERE [ConferenceRegistrationTypeId] = @OLDConferenceRegistrationTypeId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceRegistrationTypeLanguage 
Where [ConferenceRegistrationTypeId] = @OLDConferenceRegistrationTypeId
