CREATE PROCEDURE [dbo].[DeleteTransportationType]
    @ID int

AS
Begin
 Delete [Conference].[TransportationType] where     [ID] = @ID
End
