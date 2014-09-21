CREATE PROCEDURE [dbo].[UpdateSponsors]
    @OldSponsorId int,
    @SponsorName nvarchar(50),
    @ConferenceId int,
    @SponsorType nvarchar(50),
    @SponsorImage nvarchar(250)
AS
UPDATE [Conference].[Sponsors]
SET
    SponsorName = @SponsorName,
    ConferenceId = @ConferenceId,
    SponsorType = @SponsorType,
    SponsorImage = @SponsorImage
WHERE [SponsorId] = @OLDSponsorId
IF @@ROWCOUNT > 0
Select * From Conference.Sponsors 
Where [SponsorId] = @OLDSponsorId
