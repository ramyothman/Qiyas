CREATE PROCEDURE [dbo].[DeleteVenuesLanguage]
    @ID int

AS
Begin
 Delete [Conference].[VenuesLanguage] where     [ID] = @ID
End
