CREATE PROCEDURE [dbo].[GetByIDSponsors]
    @SponsorId int

AS
BEGIN
Select SponsorId, SponsorName, ConferenceId, SponsorType, SponsorImage
From [Conference].[Sponsors]

WHERE [SponsorId] = @SponsorId
END
