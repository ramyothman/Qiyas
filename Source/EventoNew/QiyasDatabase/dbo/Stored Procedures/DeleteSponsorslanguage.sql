CREATE PROCEDURE [dbo].[DeleteSponsorslanguage]
    @SponsorId int

AS
Begin
 Delete [Conference].[Sponsorslanguage] where     [SponsorId] = @SponsorId
End
