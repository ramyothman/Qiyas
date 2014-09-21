CREATE PROCEDURE InsertNewConferenceRegistrationTypeLanguage
    @ConferenceRegistrationTypeId int output ,
    @ConferenceId int,
    @Name nvarchar(50),
    @Fee decimal(18,2),
    @ConferenceRegistrationTypeParentId int,
    @LanguageID int,
    @Description nvarchar(500),
    @OfferMessage ntext
AS
INSERT INTO [Conference].[ConferenceRegistrationTypeLanguage] (
    [ConferenceId],
    [Name],
    [Fee],
    [ConferenceRegistrationTypeParentId],
    [LanguageID],
    [Description],
    [OfferMessage])
Values (
    @ConferenceId,
    @Name,
    @Fee,
    @ConferenceRegistrationTypeParentId,
    @LanguageID,
    @Description,
    @OfferMessage)
Set @ConferenceRegistrationTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegistrationTypeLanguage
Where [ConferenceRegistrationTypeId] = @@identity
