CREATE PROCEDURE [dbo].[UpdateSponsorslanguage]
    @OldSponsorId int,
    @SponsorName nvarchar(50),
    @ConferenceId int,
    @SponsorType nvarchar(50),
    @SponsorImage nvarchar(250),
    @LanguageID int,
    @SponsorParentID int
AS
UPDATE [Conference].[Sponsorslanguage]
SET
    SponsorName = @SponsorName,
    ConferenceId = @ConferenceId,
    SponsorType = @SponsorType,
    SponsorImage = @SponsorImage,
    LanguageID = @LanguageID,
    SponsorParentID = @SponsorParentID
WHERE [SponsorId] = @OLDSponsorId
IF @@ROWCOUNT > 0
Select * From Conference.Sponsorslanguage 
Where [SponsorId] = @OLDSponsorId
