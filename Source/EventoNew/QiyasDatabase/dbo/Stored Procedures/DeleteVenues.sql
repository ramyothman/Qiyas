CREATE PROCEDURE [dbo].[DeleteVenues]
    @ID int

AS
Begin
 Delete [Conference].[Venues] where     [ID] = @ID
End
