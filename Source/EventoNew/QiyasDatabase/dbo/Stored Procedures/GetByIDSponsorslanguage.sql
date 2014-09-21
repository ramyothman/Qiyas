CREATE PROCEDURE [dbo].[GetByIDSponsorslanguage]
    @SponsorId int

AS
BEGIN
Select SponsorId, SponsorName, ConferenceId, SponsorType, SponsorImage, LanguageID, SponsorParentID
From [Conference].[Sponsorslanguage]

WHERE [SponsorId] = @SponsorId
END
