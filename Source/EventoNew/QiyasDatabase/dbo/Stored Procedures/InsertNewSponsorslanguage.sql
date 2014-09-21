CREATE PROCEDURE [dbo].[InsertNewSponsorslanguage]
    @SponsorId int output ,
    @SponsorName nvarchar(50),
    @ConferenceId int,
    @SponsorType nvarchar(50),
    @SponsorImage nvarchar(250),
    @LanguageID int,
    @SponsorParentID int
AS
INSERT INTO [Conference].[Sponsorslanguage] (
    [SponsorName],
    [ConferenceId],
    [SponsorType],
    [SponsorImage],
    [LanguageID],
    [SponsorParentID])
Values (
    @SponsorName,
    @ConferenceId,
    @SponsorType,
    @SponsorImage,
    @LanguageID,
    @SponsorParentID)
Set @SponsorId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Sponsorslanguage
Where [SponsorId] = @@identity
