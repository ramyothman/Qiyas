CREATE PROCEDURE [dbo].[DeleteSponsors]
    @SponsorId int

AS
Begin
 Delete [Conference].[Sponsors] where     [SponsorId] = @SponsorId
End
