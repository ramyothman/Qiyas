CREATE PROCEDURE [dbo].[InsertNewSponsors]
    @SponsorId int output ,
    @SponsorName nvarchar(50),
    @ConferenceId int,
    @SponsorType nvarchar(50),
    @SponsorImage nvarchar(250)
AS
INSERT INTO [Conference].[Sponsors] (
    [SponsorName],
    [ConferenceId],
    [SponsorType],
    [SponsorImage])
Values (
    @SponsorName,
    @ConferenceId,
    @SponsorType,
    @SponsorImage)
Set @SponsorId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Sponsors
Where [SponsorId] = @@identity
